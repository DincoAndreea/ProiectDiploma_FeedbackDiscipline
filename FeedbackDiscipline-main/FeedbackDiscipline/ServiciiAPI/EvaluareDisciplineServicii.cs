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
    public class EvaluareDisciplineServicii : IEvaluareDisciplineServicii
    {
        IAdministrareServicii administrareServicii = new AdministrareServicii();
        public async Task<List<AniDeStudiu>> preiaAniStudiuDupaCiclulDeStudii(int id, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/AniDeStudiu/" + id;

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var json = new List<AniDeStudiu>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<AniDeStudiu>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<AniDeStudiu>>(rezultat);
                }
            }

            return json;
        }

        public async Task<List<CiclulDeStudii>> preiaCicluriStudii(string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/CiclulDeStudii";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var json = new List<CiclulDeStudii>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<CiclulDeStudii>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<CiclulDeStudii>>(rezultat);
                }
            }

            return json;
        }

        public async Task<List<Disciplina>> preiaDisciplineDupaProgramulDeStudiu(int id, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Discipline/" + id;

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var json = new List<Disciplina>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<Disciplina>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<Disciplina>>(rezultat);
                }
            }

            return json;
        }

        public async Task<List<ProgrameStudiu>> preiaProgrameStudiiDupaCiclulDeStudii(int id, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/ProgrameStudiu/" + id;

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var json = new List<ProgrameStudiu>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<ProgrameStudiu>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<ProgrameStudiu>>(rezultat);
                }
            }

            return json;
        }

        public async Task<List<TipuriActivitati>> preiaTipuriActivitati(string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/TipuriActivitati";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage raspuns = await client.GetAsync(_url);

            var json = new List<TipuriActivitati>();

            if (raspuns.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                HttpResponseMessage raspuns_nou = await client.GetAsync(_url);

                if (raspuns_nou.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat_nou = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<TipuriActivitati>>(rezultat_nou);
                }

                await SecureStorage.SetAsync("token", token_nou.token);

                await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
            }
            else
            {
                if (raspuns.StatusCode == HttpStatusCode.OK)
                {
                    var rezultat = await raspuns.Content.ReadAsStringAsync();
                    json = JsonConvert.DeserializeObject<List<TipuriActivitati>>(rezultat);
                }
            }

            return json;
        }

        public async Task<HttpStatusCode> trimiteChestionarComplet(ChestionarCompletDTO chestionar, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Chestionare/evaluareCompleta";

            var json = JsonConvert.SerializeObject(chestionar);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage rezultat = await client.PostAsync(_url, continut);

            if (rezultat.StatusCode == HttpStatusCode.NotFound || rezultat.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                json = JsonConvert.SerializeObject(chestionar);

                continut = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage rezultat_nou = await client.PostAsync(_url, continut);

                if(rezultat_nou.IsSuccessStatusCode)
                {
                    await SecureStorage.SetAsync("token", token_nou.token);

                    await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
                }

                return rezultat_nou.StatusCode;
            }

            return rezultat.StatusCode;
        }

        public async Task<HttpStatusCode> trimiteChestionarPartial(ChestionarPartialDTO chestionar, string token, string token_reimprospatare)
        {
            string _url = "https://otla7tanf3.execute-api.eu-central-1.amazonaws.com/Prod/api/Chestionare/evaluarePartiala";

            var json = JsonConvert.SerializeObject(chestionar);

            var continut = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage rezultat = await client.PostAsync(_url, continut);

            if (rezultat.StatusCode == HttpStatusCode.NotFound || rezultat.StatusCode == HttpStatusCode.Unauthorized)
            {
                Token token_cerere = new Token { token = token, token_reimprospatare = token_reimprospatare };

                Token token_nou = await administrareServicii.reimprospatareToken(token_cerere);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token_nou.token);

                json = JsonConvert.SerializeObject(chestionar);

                continut = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage rezultat_nou = await client.PostAsync(_url, continut);

                if (rezultat_nou.IsSuccessStatusCode)
                {
                    await SecureStorage.SetAsync("token", token_nou.token);

                    await SecureStorage.SetAsync("tokenReimprospatare", token_nou.token_reimprospatare);
                }

                return rezultat_nou.StatusCode;
            }

            return rezultat.StatusCode;
        }
    }
}
