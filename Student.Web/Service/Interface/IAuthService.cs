using MeuProjetoBlazor.Models;
using System.Threading.Tasks;

namespace MeuProjetoBlazor.Services;

public interface IAuthService
{
    Task<bool> Login(LoginRequest loginRequest);
    Task Logout();
}