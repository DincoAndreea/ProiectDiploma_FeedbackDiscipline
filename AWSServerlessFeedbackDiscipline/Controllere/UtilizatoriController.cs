using AWSServerlessFeedbackDiscipline.Modele;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AWSServerlessFeedbackDiscipline.Servicii;
using AWSServerlessFeedbackDiscipline.ContextBazaDeDate;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace AWSServerlessFeedbackDiscipline.Controllere
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilizatoriController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _utilizatoriManager;
        private readonly RoleManager<IdentityRole> _roluriManager;
        private readonly JWTServicii _jwt;
        private readonly FeedbackDisciplineContext _context;

        public UtilizatoriController(UserManager<IdentityUser> utilizatoriManager, JWTServicii jwt, FeedbackDisciplineContext context, RoleManager<IdentityRole> roluriManager)
        {
            _utilizatoriManager = utilizatoriManager;
            _jwt = jwt;
            _context = context;
            _roluriManager = roluriManager;
        }

        [Authorize(Roles = RoluriUtilizator.administrator)]
        [HttpGet("Utilizatori")]
        public async Task<List<NumeUtilizator>> Utilizatori()
        {
            var utilizatori = await _utilizatoriManager.Users.ToListAsync();

            List<NumeUtilizator> nume_utilizatori = new List<NumeUtilizator>();

            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].UserName != "admin")
                {
                    nume_utilizatori.Add(new NumeUtilizator { nume_utilizator = utilizatori[i].UserName });
                }
            }

            return nume_utilizatori;
        }

        [HttpPost("Inregistrare")]
        public async Task<ActionResult<Utilizator>> Inregistrare(Utilizator utilizator)
        {
            var utilizatorulExista = await _utilizatoriManager.FindByNameAsync(utilizator.nume_utilizator);

            if(utilizatorulExista != null)
            {
                return BadRequest("Utilizatorul exista deja.");
            }

            var utilizatorNou = new IdentityUser { UserName = utilizator.nume_utilizator, Email = utilizator.email, SecurityStamp = Guid.NewGuid().ToString() };

            var rezultat = await _utilizatoriManager.CreateAsync(utilizatorNou, utilizator.parola);

            if(!rezultat.Succeeded)
            {
                return BadRequest("Utilizatorul nu a fost inregistrat.");
            }

            var existaRolulStudent = await _roluriManager.RoleExistsAsync(RoluriUtilizator.student);

            if(!existaRolulStudent)
            {
                await _roluriManager.CreateAsync(new IdentityRole(RoluriUtilizator.student));
            }

            var existaRolulProfesor = await _roluriManager.RoleExistsAsync(RoluriUtilizator.profesor);

            if(!existaRolulProfesor)
            {
                await _roluriManager.CreateAsync(new IdentityRole(RoluriUtilizator.profesor));
            }

            var existaRolulAdministrator = await _roluriManager.RoleExistsAsync(RoluriUtilizator.administrator);

            if(!existaRolulAdministrator)
            {
                await _roluriManager.CreateAsync(new IdentityRole(RoluriUtilizator.administrator));
            }

            if(utilizator.rol == RoluriUtilizator.student)
            {
                await _utilizatoriManager.AddToRoleAsync(utilizatorNou, RoluriUtilizator.student);
            }

            switch(utilizator.rol)
            {
                case RoluriUtilizator.student: 
                    await _utilizatoriManager.AddToRoleAsync(utilizatorNou, RoluriUtilizator.student);
                    break;
                case RoluriUtilizator.profesor: 
                    await _utilizatoriManager.AddToRoleAsync(utilizatorNou, RoluriUtilizator.profesor);
                    break;
                case RoluriUtilizator.administrator: 
                    await _utilizatoriManager.AddToRoleAsync(utilizatorNou, RoluriUtilizator.administrator);
                    break;
            }

            return Ok("Utilizatorul a fost inregistrat.");
        }

        [HttpPost("Logare")]
        public async Task<ActionResult<AutentificareRaspuns>> Logare(AutentificareCerere cerere)
        {
            var utilizator = await _utilizatoriManager.FindByEmailAsync(cerere.email);

            if (utilizator == null)
            {
                return BadRequest("Numele de utilizator sau parola nu sunt corecte.");
            }

            var esteValidaParola = await _utilizatoriManager.CheckPasswordAsync(utilizator ,cerere.parola);

            if (!esteValidaParola)
            {
                return BadRequest("Numele de utilizator sau parola nu sunt corecte.");
            }

            if(utilizator != null && esteValidaParola)
            {
                var roluri = await _utilizatoriManager.GetRolesAsync(utilizator);
                var atribute = new List<Claim> { new Claim(ClaimTypes.Name, utilizator.UserName), new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) };

                foreach(var rolUtilizator in roluri)
                {
                    atribute.Add(new Claim(ClaimTypes.Role, rolUtilizator));
                }

                var token = _jwt.CreazaToken(utilizator, atribute);

                var tokenReimprospatare = _jwt.CreazaTokenReimprospatare();

                var informatiiToken = _context.TokenReimprospatare.FirstOrDefault(a => a.id_utilizator == utilizator.Id);

                if(informatiiToken == null)
                {
                    _context.TokenReimprospatare.Add(new TokenReimprospatare { id_utilizator = utilizator.Id, valoare = tokenReimprospatare, data_expirare = DateTime.Now.AddDays(7)});
                }
                else
                {
                    informatiiToken.valoare = tokenReimprospatare;
                    informatiiToken.data_expirare = DateTime.Now.AddDays(7);
                }

                _context.SaveChanges();

                return Ok(new AutentificareRaspuns { id_utilizator = utilizator.Id, nume_utilizator = utilizator.UserName, 
                    token = token.token, data_expirare_token = token.data_expirare_token, token_reimprospatare = tokenReimprospatare, 
                    data_expirare_token_reimprospatare = DateTime.Now.AddDays(7), rol = roluri.First() });
            }

            return Ok(new AutentificareRaspuns { nume_utilizator = null});
        }

        [Authorize(Roles = RoluriUtilizator.administrator)]
        [HttpPost("StergeUtilizator")]
        public async Task<IActionResult> StergeUtilizator(NumeUtilizator nume_utilizator)
        {
            var utilizator = await _utilizatoriManager.FindByNameAsync(nume_utilizator.nume_utilizator);

            if(utilizator == null)
            {
                return BadRequest("Utilizatorul nu exista.");
            }

            var rezultat = await _utilizatoriManager.DeleteAsync(utilizator);

            if(!rezultat.Succeeded)
            {
                return BadRequest("Utilizatorul nu a fost sters.");
            }

            return Ok("Utilizatorul a fost sters cu succes.");
        }

        [HttpPost("Token")]
        public async Task<IActionResult> TokenReimprospatare(CerereTokenReimprospatare cerereToken)
        {
            if(cerereToken == null)
            {
                return BadRequest("Cerere invalida.");
            }

            string token = cerereToken.token;
            string tokenReimprospatare = cerereToken.token_reimprospatare;
            var principal = _jwt.TokenExpiratInformatii(token);
            var numeUtilizator = principal.Identity.Name;
            IdentityUser idUtilizator = await _utilizatoriManager.FindByNameAsync(numeUtilizator);
            var utilizator = _context.TokenReimprospatare.SingleOrDefault(u => u.id_utilizator == idUtilizator.Id);

            if(utilizator == null || utilizator.valoare != tokenReimprospatare || utilizator.data_expirare <= DateTime.Now)
            {
                return BadRequest("Cerere invalida");
            }

            var tokenNou = _jwt.CreazaToken(idUtilizator, principal.Claims);
            var tokenReimprospatareNou = _jwt.CreazaTokenReimprospatare();
            utilizator.valoare = tokenReimprospatareNou;

            await _context.SaveChangesAsync();

            return Ok(new CerereTokenReimprospatare()
            {
                token = tokenNou.token,
                token_reimprospatare = tokenReimprospatareNou
            });
        }


    }
}
