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

        public SolicitacaoProjeto Delete(int id)
        {
            throw new System.NotImplementedException();
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
                throw new Exception(e.Message);
            }
        }

        public SolicitacaoProjeto Update(SolicitacaoProjeto value)
        {
            throw new System.NotImplementedException();
        }

    }
}
