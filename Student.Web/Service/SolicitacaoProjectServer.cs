using Student.Web.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Student.Web.Service
{
    public class SolicitacaoProjectServer 
    {
        public readonly HttpClient httpClient;
        const string site = "http://localhost:46497/api/SolicitacaoProjeto";

        public SolicitacaoProjectServer(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> Create(SolicitacaoProjeto value)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.PostAsJsonAsync<SolicitacaoProjeto>(site + "/",value);
                return a.StatusCode.ToString();
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<string> Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.DeleteAsync($"{site}/{id}");
                return a.StatusCode.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<SolicitacaoProjeto> FindById(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<SolicitacaoProjeto>(site + "/" + id);
                return a;
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task<IEnumerable<SolicitacaoProjeto>> GetAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<IEnumerable<SolicitacaoProjeto>>(site + "/" );
                return a;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<SolicitacaoProjeto>> GetProjetosByUsuario(int idUsuario)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<IEnumerable<SolicitacaoProjeto>>($"{site}/usuario/{idUsuario}");
                return a;
            }
            catch (Exception)
            {
                return new List<SolicitacaoProjeto>();
            }
        }

        public SolicitacaoProjeto Update(SolicitacaoProjeto value)
        {
            throw new System.NotImplementedException();
        }

    }
}
