using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IPerfilRepository : IRepositoryBase<Perfil>
    {
        Task<PaginatedBase<Perfil>> GetAllWithPaginated(PerfilQuery query);
    }
}
