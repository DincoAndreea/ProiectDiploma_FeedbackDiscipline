using FeedbackDiscipline.Modele;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackDiscipline.ServiciiAPI
{
    public interface IEvaluareDisciplineServicii
    {
        Task<List<AniDeStudiu>> preiaAniStudiuDupaCiclulDeStudii(int id, string token, string token_reimprospatare);
        Task<List<CiclulDeStudii>> preiaCicluriStudii(string token, string token_reimprospatare);
        Task<List<Disciplina>> preiaDisciplineDupaProgramulDeStudiu(int id, string token, string token_reimprospatare);
        Task<List<TipuriActivitati>> preiaTipuriActivitati(string token, string token_reimprospatare);
        Task<List<ProgrameStudiu>> preiaProgrameStudiiDupaCiclulDeStudii(int id, string token, string token_reimprospatare);
        Task<HttpStatusCode> trimiteChestionarPartial(ChestionarPartialDTO chestionar, string token, string token_reimprospatare);
        Task<HttpStatusCode> trimiteChestionarComplet(ChestionarCompletDTO chestionar, string token, string token_reimprospatare);
    }
}
