using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Integration.Response;

namespace WMS.Sisdep.Infra.Integration.Interfaces
{
    public interface IIntegrationAuthorizeClientService
    {
        Task<LoginResponse> Login(LoginBody body);
        Task AddSession(SessaoBody body);
        Task DeleteSession(SessaoBody body);
        Task<IEnumerable<ListarEmpresaResponse>> GetCompanyByNameGroup(string grupo);
        Task<ObterBancoDadosResponse> GetDatabaseWithFilter(string grupo, string empresa);
    }
}
