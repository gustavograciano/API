using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IPerfilApplicationService
    {
        Task Add(PerfilBody body);
        Task<PaginatedBaseDTO<PerfilDTO>> GetAllWithPaginated(PerfilQuery query);
        Task<PerfilDTO> GetById(Guid id);
        Task Update(Guid id,PerfilBody body);
        Task Remove(Guid id);

    }
}
