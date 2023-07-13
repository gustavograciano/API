using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IEmpresaApplicationService
    {
        Task<PaginatedBaseDTO<EmpresaDTO>> GetAllWithPaginated(EmpresaQuery query);
    }
}
