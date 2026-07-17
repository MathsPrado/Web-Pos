using Student.Web.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Student.Web.Service
{
    public class PerfilEmpresaService
    {
        private readonly HttpClient httpClient;
        private const string site = "http://localhost:46497/api/PerfilEmpresa";

        public PerfilEmpresaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> Create(PerfilEmpresa value)
        {
            try
            {
                var a = await httpClient.PostAsJsonAsync<PerfilEmpresa>(site, value);
                return a.StatusCode.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<PerfilEmpresa> GetCompanyByEmailAsync(string email)
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<PerfilEmpresa>($"{site}/email/{email}");
                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<PerfilEmpresa> Update(PerfilEmpresa value)
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync<PerfilEmpresa>($"{site}/{value.Id}", value);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PerfilEmpresa>();
                }
                throw new Exception("Erro ao atualizar perfil da empresa.");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
