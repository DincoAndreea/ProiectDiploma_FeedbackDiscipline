using FeedbackDiscipline.Modele;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FeedbackDiscipline.ServiciiAPI
{
    public class AdministrareServicii : IAdministrareServicii
    {
        public async Task<HttpStatusCode> Inregistrare(Inregistrare inregistrare, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Utilizatori/Inregistrare";

            var json = JsonConvert.SerializeObject(inregistrare);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.PostAsync(_url, continut);

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized || raspuns.StatusCode == HttpStatusCode.NotFound)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                json = JsonConvert.SerializeObject(inregistrare);

                continut = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage raspuns_nou = await client.PostAsync(_url, continut);

                if (raspuns_nou.IsSuccessStatusCode)
                {
                    await SecureStorage.SetAsync("token", token_nou.token);

                    await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
                }

                return raspuns_nou.StatusCode;
            }

            return raspuns.StatusCode;
        }

        public async Task<Autentificare> Logare(Logare logare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Utilizatori/Logare";

            var json = JsonConvert.SerializeObject(logare);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            HttpResponseMessage raspuns = await client.PostAsync(_url, continut);

            var detalii = new Autentificare();

            if (raspuns.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rezultat = await raspuns.Content.ReadAsStringAsync();
                detalii = JsonConvert.DeserializeObject<Autentificare>(rezultat);
            }

            return detalii;
        }

        public async Task<Token> reimprospatareToken(Token token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Utilizatori/Token";

            var json = JsonConvert.SerializeObject(token_reimprospatare);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            HttpResponseMessage raspuns = await client.PostAsync(_url, continut);

            var detalii = new Token();

            if (raspuns.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rezultat = await raspuns.Content.ReadAsStringAsync();
                detalii = JsonConvert.DeserializeObject<Token>(rezultat);
            }

            return detalii;
        }

        public async Task<HttpStatusCode> StergeUtilizator(Utilizatori nume_utilizator, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Utilizatori/StergeUtilizator";

            var json = JsonConvert.SerializeObject(nume_utilizator);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.PostAsync(_url, continut);

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized || raspuns.StatusCode == HttpStatusCode.NotFound)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                json = JsonConvert.SerializeObject(nume_utilizator);

                continut = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage raspuns_nou = await client.PostAsync(_url, continut);

                if (raspuns_nou.IsSuccessStatusCode)
                {
                    await SecureStorage.SetAsync("token", token_nou.token);

                    await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
                }

                return raspuns_nou.StatusCode;
            }

            return raspuns.StatusCode;
        }

        public async Task<List<Utilizatori>> Utilizatori(string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Utilizatori/Utilizatori";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var detalii = new List<Utilizatori>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    detalii = JsonConvert.DeserializeObject<List<Utilizatori>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    detalii = JsonConvert.DeserializeObject<List<Utilizatori>>(rezultat);
                }
            }

            return detalii;
        }
    }
}
