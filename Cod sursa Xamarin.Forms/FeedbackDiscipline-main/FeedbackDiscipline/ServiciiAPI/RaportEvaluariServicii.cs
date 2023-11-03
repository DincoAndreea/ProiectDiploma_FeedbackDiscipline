using FeedbackDiscipline.Modele;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FeedbackDiscipline.ServiciiAPI
{
    public class RaportEvaluariServicii : IRaportEvaluariServicii
    {
        IAdministrareServicii administrareServicii = new AdministrareServicii();
        public async Task<RaportComplet> preiaRaport(RaportDTO raport, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/RaspunsuriChestionar/raportComplet";

            var json = JsonConvert.SerializeObject(raport);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.PostAsync(_url, continut);

            var jsonRezultat = new RaportComplet();

            if (raspuns.StatusCode == HttpStatusCode.NotFound || raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                json = JsonConvert.SerializeObject(raport);

                continut = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage rezultat_nou = await client.PostAsync(_url, continut);

                if (rezultat_nou.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    jsonRezultat = JsonConvert.DeserializeObject<RaportComplet>(rezultat);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                var rezultat = await raspuns.Content.ReadAsStringAsync();
                jsonRezultat = JsonConvert.DeserializeObject<RaportComplet>(rezultat);
            }

            return jsonRezultat;
        }
    }
}
