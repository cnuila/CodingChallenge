using System;
using System.Threading.Tasks;
using FlamingSoftHR.Shared;

namespace FlamingSoftHR.Client.Services
{
    public interface IAuthService
    {
        Task<LoginDataResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterDataResult> Register(RegisterModel registerModel);
    }
}
