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
    public class DisciplineController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public DisciplineController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        // GET: api/Discipline
        [Authorize(Roles = RoluriUtilizator.student + "," + RoluriUtilizator.profesor)]
        [HttpGet("{program_de_studiu:int}")]
        public async Task<ActionResult<IEnumerable<Discipline>>> PreiaDiscipline([FromRoute] int program_de_studiu)
        {
            var programDeStudiu = await _context.ProgrameDeStudiu.FindAsync(program_de_studiu);

            if (programDeStudiu == null)
            {
                return NotFound();
            }

            return await _context.Discipline.Where(p => p.program_de_studii == program_de_studiu).ToListAsync();
        }


    }
}
