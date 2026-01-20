using MeuProjetoBlazor.Models;
using MeuProjetoBlazor.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop; // Necessário para o Cookie
using Student.Web.Auth;
using Student.Web.Model; // Ajuste para seu namespace de Models
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Student.Web.Service;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authStateProvider;
    private readonly IJSRuntime _jsRuntime; // Usamos JS para gravar Cookie

    public AuthService(HttpClient httpClient,
                       AuthenticationStateProvider authStateProvider,
                       IJSRuntime jsRuntime)
    {
        _httpClient = httpClient;
        _authStateProvider = authStateProvider;
        _jsRuntime = jsRuntime;
    }

    public async Task<bool> Login(LoginRequest loginRequest)
    {
        // 1. URL FIXA DO LOGIN (Como o senhor pediu)
        var urlLogin = "https://localhost:44303/api/Auth/login";

        try
        {
            // O HttpClient usa a URL completa, ignorando o BaseAddress se houver
            var result = await _httpClient.PostAsJsonAsync(urlLogin, loginRequest);

            if (!result.IsSuccessStatusCode)
                return false;

            var content = await result.Content.ReadFromJsonAsync<LoginResponse>();

            if (content == null || string.IsNullOrEmpty(content.Token))
                return false;

            // Ao passar "0", o JavaScript entende que não deve pôr data de validade.
            // O navegador entende isso como "Delete ao fechar a janela".
            await _jsRuntime.InvokeVoidAsync("blazorExtensions.writeCookie", "authToken", content.Token, 0);

            // 3. Notificar o sistema
            ((CustomAuthStateProvider)_authStateProvider).NotifyUserLogin(content.Token);

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no login: {ex.Message}");
            return false;
        }
    }

    public async Task Logout()
    {
        // Remove o Cookie usando a mesma chave simples "authToken"
        await _jsRuntime.InvokeVoidAsync("blazorExtensions.deleteCookie", "authToken");

        ((CustomAuthStateProvider)_authStateProvider).NotifyUserLogout();
    }
}