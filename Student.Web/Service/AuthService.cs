using Blazored.LocalStorage;
using MeuProjetoBlazor.Models;

using MeuProjetoBlazor.Services;

// using Intersoft.Crosslight.Mobile; <--- REMOVA ESTA LINHA
using Microsoft.AspNetCore.Components.Authorization;
using Student.Web.Auth;
using Student.Web.Model; // Certifique-se que seus DTOs estão aqui
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Student.Web.Service; // Ajustado para o nome do seu projeto

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authStateProvider;
    private readonly ILocalStorageService _localStorage;

    public AuthService(HttpClient httpClient,
                       AuthenticationStateProvider authStateProvider,
                       ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _authStateProvider = authStateProvider;
        _localStorage = localStorage;
    }

    public async Task<bool> Login(LoginRequest loginRequest)
    {
        var urlLogin = "https://localhost:44303/api/Auth/login"; //fixx

        var result = await _httpClient.PostAsJsonAsync(urlLogin, loginRequest);

        if (!result.IsSuccessStatusCode)
            return false;

        var content = await result.Content.ReadFromJsonAsync<LoginResponse>();

        if (content == null || string.IsNullOrEmpty(content.Token))
            return false;

        var urlToken = "https://localhost:44303/api/Auth/authToken"; //fixx

        await _localStorage.SetItemAsync(urlToken, content.Token);

        ((CustomAuthStateProvider)_authStateProvider).NotifyUserLogin(content.Token);

        return true;
    }

    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");
        ((CustomAuthStateProvider)_authStateProvider).NotifyUserLogout();
    }
}