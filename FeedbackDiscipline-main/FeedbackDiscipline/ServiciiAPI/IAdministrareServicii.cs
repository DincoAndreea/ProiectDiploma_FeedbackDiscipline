using FeedbackDiscipline.Modele;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackDiscipline.ServiciiAPI
{
    public interface IAdministrareServicii
    {
        Task<Autentificare> Logare(Logare logare);
        Task<HttpStatusCode> Inregistrare(Inregistrare inregistrare, string token, string token_reimprospatare);
        Task<Token> reimprospatareToken(Token token_reimprospatare);
        Task<List<Utilizatori>> Utilizatori(string token, string token_reimprospatare);
        Task<HttpStatusCode> StergeUtilizator(Utilizatori nume_utilizator, string token, string token_reimprospatare);
    }
}
