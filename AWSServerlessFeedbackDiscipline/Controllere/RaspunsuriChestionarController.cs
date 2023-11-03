using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AWSServerlessFeedbackDiscipline.ContextBazaDeDate;
using AWSServerlessFeedbackDiscipline.Modele;
using NuGet.Protocol;
using System.Configuration;
using Dapper;
using System.Data;
using System.Reflection;
using MySqlConnector;
using Microsoft.AspNetCore.Authorization;

namespace AWSServerlessFeedbackDiscipline.Controllere
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaspunsuriChestionarController : ControllerBase
    {
        private readonly FeedbackDisciplineContext _context;

        private readonly IConfiguration _configuratie;

        public RaspunsuriChestionarController(FeedbackDisciplineContext context, IConfiguration config)
        {
            _context = context;
            _configuratie = config;
        }

        [Authorize(Roles = RoluriUtilizator.profesor)]
        [HttpPost("raportComplet")]
        public async Task<ActionResult<RaportComplet>> PreiaRaportComplet(RaportDTO raportDTO)
        {
            RaportComplet raport = new RaportComplet();
            try
            {
                var parametri = new DynamicParameters();
                parametri.Add("disciplina", raportDTO.id_disciplina, DbType.Int32, ParameterDirection.Input);
                parametri.Add("tipActivitate", raportDTO.id_tip_activitate, DbType.Int32, ParameterDirection.Input);

                var conexiune = new MySqlConnection(Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(_configuratie, "FeedbackDisciplineContext"));

                var rezultat = await conexiune.QueryMultipleAsync("raport_complet", parametri, commandType: CommandType.StoredProcedure);

                raport.intrebarea1 = rezultat.Read<Raport>().ToList();
                raport.intrebarea2 = rezultat.Read<Raport>().ToList();
                raport.intrebarea3 = rezultat.Read<Raport>().ToList();
                raport.intrebarea4 = rezultat.Read<Raport>().ToList();
                raport.intrebarea5 = rezultat.Read<Raport>().ToList();
                raport.intrebarea6 = rezultat.Read<Raport>().ToList();
                raport.intrebarea7 = rezultat.Read<Raport>().ToList();
                raport.intrebarea8 = rezultat.Read<Raport>().ToList();
                raport.intrebarea9 = rezultat.Read<Raport>().ToList();
                raport.intrebarea10 = rezultat.Read<Raport>().ToList();
                raport.intrebarea11 = rezultat.Read<Raport>().ToList();
                raport.intrebarea12 = rezultat.Read<Raport>().ToList();
                raport.intrebarea13 = rezultat.Read<Raport>().ToList();
                raport.intrebarea14 = rezultat.Read<Raport>().ToList();
                raport.intrebarea15 = rezultat.Read<Raport>().ToList();
                raport.intrebarea16 = rezultat.Read<Raport>().ToList();
            }
            catch(MySqlException e)
            {
                return Problem(e.Message);
            }

            return Ok(raport);
        }
    }
}
