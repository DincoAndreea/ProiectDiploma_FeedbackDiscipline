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
    public class ProgrameStudiuController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public ProgrameStudiuController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        // GET: api/ProgrameStudiu
        [Authorize(Roles = RoluriUtilizator.student + "," + RoluriUtilizator.profesor)]
        [HttpGet("{ciclul_de_studii:int}")]
        public async Task<ActionResult<IEnumerable<ProgrameStudiu>>> PreiaProgrameStudiu([FromRoute] int ciclul_de_studii)
        {
            var ciclulDeStudii = await _context.ProgrameDeStudiu.FindAsync(ciclul_de_studii);

            if (ciclulDeStudii == null)
            {
                return NotFound();
            }

            return await _context.ProgrameDeStudiu.Where(c => c.id_ciclul_de_studii == ciclul_de_studii).ToListAsync();
        }
    }
}
