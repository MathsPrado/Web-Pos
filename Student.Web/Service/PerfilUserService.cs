using Student.Web.Model;
using Student.Web.Pages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Student.Web.Service
{
    public class PerfilUserService
    {
        public readonly HttpClient httpClient;
        const string site = "http://localhost:46497/api/ProfileUser";

        public PerfilUserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> Create(PerfilUser value)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.PostAsJsonAsync<PerfilUser>(site + "/",value);
                return a.StatusCode.ToString();
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PerfilUser Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PerfilUser> FindById(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<PerfilUser>(site + "/" + id);
                return a;
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<PerfilUser> FindByEmail(string email)
        {
            try
            {
                HttpClient client = new HttpClient();
                var url = site + "/email/" + email;
                System.Console.WriteLine($"[DIAG SERVICE] Fetching profile from: {url}");
                var response = await client.GetAsync(url).ConfigureAwait(false);
                System.Console.WriteLine($"[DIAG SERVICE] HTTP status: {response.StatusCode}");
                var contentStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                System.Console.WriteLine($"[DIAG SERVICE] Content: {contentStr}");
                var options = new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var a = System.Text.Json.JsonSerializer.Deserialize<PerfilUser>(contentStr, options);
                System.Console.WriteLine($"[DIAG SERVICE] Fetch success! Name: {a?.Nome}, Skills: {a?.Skills?.Count}");
                return a;
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"[DIAG SERVICE] ERROR fetching profile: {e.GetType().Name} - {e.Message}");
                System.Console.WriteLine(e.StackTrace);
                return null;
            }
        }


        public async Task<IEnumerable<PerfilUser>> GetAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<IEnumerable<PerfilUser>>(site + "/" );
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PerfilUser Update(PerfilUser value)
        {
            throw new System.NotImplementedException();
        }

    }
}
