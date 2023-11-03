using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AWSServerlessFeedbackDiscipline.ContextBazaDeDate;
using AWSServerlessFeedbackDiscipline.Modele;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace AWSServerlessFeedbackDiscipline.Controllere
{
    [Route("api/[controller]")]
    [ApiController]
    public class AniDeStudiuController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public AniDeStudiuController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        // GET: api/AniDeStudiu
        [Authorize(Roles = RoluriUtilizator.student + "," + RoluriUtilizator.profesor)]
        [HttpGet("{ciclul_de_studii:int}")]
        public async Task<ActionResult<IEnumerable<AniDeStudiu>>> PreiaAniDeStudiu([FromRoute] int ciclul_de_studii)
        {
            var cicluDeStudii = await _context.CiclulDeStudii.FindAsync(ciclul_de_studii);

            if (cicluDeStudii == null)
            {
                return NotFound();
            }

            return await _context.AniDeStudiu.Where(c => c.ciclul_de_studii == ciclul_de_studii).ToListAsync();
        }

    }
}
