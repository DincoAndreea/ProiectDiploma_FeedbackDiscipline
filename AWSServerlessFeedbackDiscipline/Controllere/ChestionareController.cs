using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AWSServerlessFeedbackDiscipline.ContextBazaDeDate;
using AWSServerlessFeedbackDiscipline.Modele;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace AWSServerlessFeedbackDiscipline.Controllere
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChestionareController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        public ChestionareController(FeedbackDisciplineContext context)
        {
            _context = context;
        }

        [Authorize(Roles = RoluriUtilizator.student)]
        [HttpPost("evaluarePartiala")]
        public async Task<IActionResult> ChestionarPartial(ChestionarPartialDTO chestionarPartialDTO)
        {
            if(!ChestionareExists(chestionarPartialDTO.id_student, chestionarPartialDTO.id_disciplina, chestionarPartialDTO.id_tip_activitate, chestionarPartialDTO.numar_activitate))
            {
                await _context.Database.ExecuteSqlRawAsync("CALL chestionar_partial({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})", chestionarPartialDTO.id_student,
                                                                                                                                                        chestionarPartialDTO.id_disciplina,
                                                                                                                                                        chestionarPartialDTO.id_an_de_studiu,
                                                                                                                                                        chestionarPartialDTO.id_program_de_studiu,
                                                                                                                                                        chestionarPartialDTO.id_tip_activitate,
                                                                                                                                                        chestionarPartialDTO.numar_activitate,
                                                                                                                                                        chestionarPartialDTO.text_raspuns1,
                                                                                                                                                        chestionarPartialDTO.text_raspuns5,
                                                                                                                                                        chestionarPartialDTO.text_raspuns6,
                                                                                                                                                        chestionarPartialDTO.text_raspuns7,
                                                                                                                                                        chestionarPartialDTO.text_raspuns8,
                                                                                                                                                        chestionarPartialDTO.text_raspuns10,
                                                                                                                                                        chestionarPartialDTO.text_raspuns11,
                                                                                                                                                        chestionarPartialDTO.text_raspuns15,
                                                                                                                                                        chestionarPartialDTO.text_raspuns16);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Conflict();
            }
            return NoContent();
        }

        [Authorize(Roles = RoluriUtilizator.student)]
        [HttpPost("evaluareCompleta")]
        public async Task<IActionResult> ChestionarComplet(ChestionarCompletDTO chestionarCompletDTO)
        {
            if(!ChestionareExists(chestionarCompletDTO.id_student, chestionarCompletDTO.id_disciplina, chestionarCompletDTO.id_tip_activitate, chestionarCompletDTO.numar_activitate))
            {
                await _context.Database.ExecuteSqlRawAsync("CALL chestionar_complet({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21})", chestionarCompletDTO.id_student,
                                                                                                                                                                                           chestionarCompletDTO.id_disciplina,
                                                                                                                                                                                           chestionarCompletDTO.id_an_de_studiu,
                                                                                                                                                                                           chestionarCompletDTO.id_program_de_studiu,
                                                                                                                                                                                           chestionarCompletDTO.id_tip_activitate,
                                                                                                                                                                                           chestionarCompletDTO.numar_activitate,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns1,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns2,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns3,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns4,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns5,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns6,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns7,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns8,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns9,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns10,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns11,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns12,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns13,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns14,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns15,
                                                                                                                                                                                           chestionarCompletDTO.text_raspuns16);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Conflict();
            }

            return NoContent();
        }

        private bool ChestionareExists(string id_student, int id_disciplina, int id_tip_activitate, int numar_activitate)
        {
            return (_context.Chestionare?.Any(e => e.id_student == id_student && e.id_disciplina == id_disciplina && e.id_tip_activitate == id_tip_activitate && e.numar_activitate == numar_activitate)).GetValueOrDefault();
        }
    }
}
