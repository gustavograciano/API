using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Task<Usuario> GetByUser(LoginBody body);
        Task<PaginatedBase<Usuario>> GetAllWithPaginated(UsuarioQuery query);

        Task AddUsuarioEmpresa(UsuarioEmpresa usuarioEmpresa);

    }
}
