using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http; // Para IHttpContextAccessor
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace Student.Web.Auth;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly HttpClient _http;
    private ClaimsPrincipal _currentUser = new ClaimsPrincipal(new ClaimsIdentity());

    // Removemos LocalStorage e injetamos HttpContextAccessor
    public CustomAuthStateProvider(IHttpContextAccessor httpContextAccessor, HttpClient http)
    {
        _httpContextAccessor = httpContextAccessor;
        _http = http;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        if (_currentUser.Identity?.IsAuthenticated == true)
        {
            return Task.FromResult(new AuthenticationState(_currentUser));
        }

        string token = null;

        if (_httpContextAccessor.HttpContext?.Request?.Cookies.TryGetValue("authToken", out var cookieToken) == true)
        {
            token = cookieToken;
        }

        // Se não achou token
        if (string.IsNullOrWhiteSpace(token))
        {
            return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
        }

        // Se achou, configura o usuário
        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt", "unique_name", "role");
        _currentUser = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(_currentUser));
    }

    // Métodos NotifyUserLogin, NotifyUserLogout e ParseClaims (mantém iguais)
    public void NotifyUserLogin(string token)
    {
        _currentUser = new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt", "unique_name", "role"));
        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var authState = Task.FromResult(new AuthenticationState(_currentUser));
        NotifyAuthenticationStateChanged(authState);
    }

    public void NotifyUserLogout()
    {
        _currentUser = new ClaimsPrincipal(new ClaimsIdentity());
        _http.DefaultRequestHeaders.Authorization = null;
        var authState = Task.FromResult(new AuthenticationState(_currentUser));
        NotifyAuthenticationStateChanged(authState);
    }

    private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
    {
        var payload = jwt.Split('.')[1];
        var jsonBytes = ParseBase64WithoutPadding(payload);
        var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
        return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
    }

    private byte[] ParseBase64WithoutPadding(string base64)
    {
        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }
        return Convert.FromBase64String(base64);
    }
}
