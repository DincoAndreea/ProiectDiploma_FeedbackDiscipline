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

namespace AWSServerlessFeedbackDiscipline.Controllere
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiclulDeStudiiController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public CiclulDeStudiiController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        // GET: api/CiclulDeStudii
        [Authorize(Roles = RoluriUtilizator.student + "," + RoluriUtilizator.profesor)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CiclulDeStudii>>> PreiaCiclulDeStudii()
        {
          if (_context.CiclulDeStudii == null)
          {
              return NotFound();
          }
            return await _context.CiclulDeStudii.ToListAsync();
        }

    }
}
