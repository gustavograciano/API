using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.OldData.Models;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IUsuarioDomainService
    {
        Task<IEnumerable<UsuarioOldModel>> GetAllOld();
        Task Add(UsuarioBody body);
        Task<IEnumerable<UsuarioModel>> GetAll();
        Task<UsuarioModel> GetById(Guid id);
        Task Update(Guid id, UsuarioBody body);
        Task Remove(Guid id);
        Task<PaginatedBaseModel<UsuarioModel>> GetAllWithPaginated(UsuarioQuery query);

    }
}
