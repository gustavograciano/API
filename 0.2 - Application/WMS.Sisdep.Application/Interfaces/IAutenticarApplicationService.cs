using Newtonsoft.Json.Linq;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Domain.Core.Bodies;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IAutenticarApplicationService
    {
        Task<LoginDTO> Login(LoginBody body);
        Task Logout(LogoutBody body);    }
}
