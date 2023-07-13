using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Integration.Response;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IAuthorizeClientApplicationService
    {
        Task<LoginResponse> Login(LoginBody body);
        Task AddSession(SessaoBody body);
        Task<IEnumerable<ListarEmpresaResponse>> GetCompanyByNameGroup(string grupo);
    }
}
