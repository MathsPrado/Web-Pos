using Blazored.LocalStorage; // <--- 1. IMPORTANTE: Adicione este using
using MeuProjetoBlazor.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Student.Web.Auth;
using Student.Web.Data;
using Student.Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; // Necessário para configurar o HttpClient
using System.Threading.Tasks;

namespace Student.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Serviços existentes
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<SolicitacaoProjectServer>();
            services.AddSingleton<PropostaSolicitacaoProjetoServer>();
            services.AddSingleton<PerfilUserService>();

            // --- 2. CORREÇÃO DO ERRO DE LOCAL STORAGE ---
            // Isso resolve o erro: "Unable to resolve service for type Blazored.LocalStorage"
            services.AddBlazoredLocalStorage();

            // --- 3. CONFIGURAÇÃO DA AUTENTICAÇÃO ---
            services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

            // --- 4. CONFIGURAÇÃO DO AUTH SERVICE COM ENDEREÇO DA API ---
            // Em vez de apenas AddScoped, usamos AddHttpClient para já definir a URL base da API
            // ATENÇÃO: Verifique se a porta 7152 é a correta da sua API rodando
            services.AddHttpClient<IAuthService, AuthService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7152/");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}