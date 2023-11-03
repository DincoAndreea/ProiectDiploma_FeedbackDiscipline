using FeedbackDiscipline.Modele;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackDiscipline.ServiciiAPI
{
    public interface IRaportEvaluariServicii
    {
        Task<RaportComplet> preiaRaport(RaportDTO raport, string token, string token_reimprospatare);
    }
}
