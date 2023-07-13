using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IAutenticarDomainService
    {
        Task<UsuarioModel> Login(LoginBody body);
    }
}
