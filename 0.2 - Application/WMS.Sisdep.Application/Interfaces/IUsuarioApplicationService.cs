using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.OldData.DTOs;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IUsuarioApplicationService
    {
        Task<IEnumerable<UsuarioOldDTO>> GetAllOld();
        Task Add(UsuarioBody body);
        Task<IEnumerable<UsuarioDTO>> GetAll();
        Task<UsuarioDTO> GetById(Guid id);
        Task Update(Guid id, UsuarioBody body);
        Task Remove(Guid id);
        Task<PaginatedBaseDTO<UsuarioDTO>> GetAllWithPaginated(UsuarioQuery query);

    }
}
