using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IEmpresaDomainService
    {
        Task<PaginatedBaseModel<EmpresaModel>> GetAllWithPaginated(EmpresaQuery query);
    }
}
