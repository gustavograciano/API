using WMS.Sisdep.Application.Core.DTOs;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IConfigApplicationService
    {
        Task<ObterInformacaoGrupoDTO> GetInformation(string grupo);
    }
}
