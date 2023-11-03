using AWSServerlessFeedbackDiscipline.Modele;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace AWSServerlessFeedbackDiscipline.Servicii
{
    public class JWTServicii
    {

        private readonly IConfiguration _configuratie;

        public JWTServicii(IConfiguration config)
        {
            _configuratie = config;
        }

        public AutentificareRaspuns CreazaToken(IdentityUser utilizator, IEnumerable<Claim> atribute)
        {
            var expirare = DateTime.UtcNow.AddMinutes(30);

            var cheie = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuratie["Jwt:Cheie"]));

            var token = new JwtSecurityToken(issuer: _configuratie["Jwt:Emitent"], audience: _configuratie["Jwt:Audienta"],
                expires: expirare, claims: atribute, signingCredentials: new SigningCredentials(cheie, SecurityAlgorithms.HmacSha256));

            var tokenHandler = new JwtSecurityTokenHandler();

            return new AutentificareRaspuns
            {
                token = tokenHandler.WriteToken(token),
                data_expirare_token = expirare,
                id_utilizator = utilizator.Id
            };
        }

        public string CreazaTokenReimprospatare()
        {
            var numar = new byte[32];
            using(var n = RandomNumberGenerator.Create())
            {
                n.GetBytes(numar);
                return Convert.ToBase64String(numar);   
            }
        }

        public ClaimsPrincipal TokenExpiratInformatii(string token)
        {
            var tokenValidare = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuratie["Jwt:Cheie"])),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken tokenSecuritate;
            var principal = tokenHandler.ValidateToken(token, tokenValidare, out tokenSecuritate);
            var tokenSecuritateJwt = tokenSecuritate as JwtSecurityToken;

            if(tokenSecuritateJwt == null || !tokenSecuritateJwt.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Token invalid");
            }

            return principal;
        }
    }
}
