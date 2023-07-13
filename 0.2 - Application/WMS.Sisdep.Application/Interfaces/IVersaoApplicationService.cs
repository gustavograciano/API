using WMS.Sisdep.Application.Core.DTOs;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IVersaoApplicationService
    {
        Task<VersaoDTO> Get();
    }
}
