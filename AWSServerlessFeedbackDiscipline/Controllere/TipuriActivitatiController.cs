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
    public class TipuriActivitatiController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public TipuriActivitatiController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        // GET: api/TipuriActivitati
        [Authorize(Roles = RoluriUtilizator.student + "," + RoluriUtilizator.profesor)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipuriActivitati>>> PreiaTipuriActivitati()
        {
          if (_context.TipuriActivitati == null)
          {
              return NotFound();
          }
            return await _context.TipuriActivitati.ToListAsync();
        }
    }
}
