using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IEmpresaRepository : IRepositoryBase<Empresa>
    {
        Task<PaginatedBase<Empresa>> GetAllWithPaginated(EmpresaQuery query);
    }
}
