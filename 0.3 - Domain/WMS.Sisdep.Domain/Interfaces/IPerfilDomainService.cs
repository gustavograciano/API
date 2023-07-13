using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IPerfilDomainService
    {
        Task Add(PerfilBody body);
        Task<PaginatedBaseModel<PerfilModel>> GetAllWithPaginated(PerfilQuery query);
        Task<PerfilModel> GetById(Guid id);
        Task Update(Guid id, PerfilBody body);
        Task Remove(Guid id);
    }
}
