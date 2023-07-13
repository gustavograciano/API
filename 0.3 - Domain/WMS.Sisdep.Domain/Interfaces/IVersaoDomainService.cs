using WMS.Sisdep.Domain.Core.Models;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IVersaoDomainService
    {
        Task<VersaoModel> Get();
    }
}
