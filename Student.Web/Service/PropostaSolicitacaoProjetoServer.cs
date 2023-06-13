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
    public class PropostaSolicitacaoProjetoServer
    {
        public readonly HttpClient httpClient;
        const string site = "http://localhost:46497/api/SolicitacaoProjeto";

        public PropostaSolicitacaoProjetoServer(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> Create(PropostaSolicitacaoProjeto value)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.PostAsJsonAsync<PropostaSolicitacaoProjeto>(site + "/",value);
                return a.StatusCode.ToString();
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PropostaSolicitacaoProjeto Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PropostaSolicitacaoProjeto> FindById(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<PropostaSolicitacaoProjeto>(site + "/" + id);
                return a;
                //var result = await httpClient.GetJsonAsync<SolicitacaoProjeto>("api/employees");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task<IEnumerable<PropostaSolicitacaoProjeto>> GetAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                var a = await client.GetFromJsonAsync<IEnumerable<PropostaSolicitacaoProjeto>>(site + "/" );
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PropostaSolicitacaoProjeto Update(PropostaSolicitacaoProjeto value)
        {
            throw new System.NotImplementedException();
        }

    }
}
