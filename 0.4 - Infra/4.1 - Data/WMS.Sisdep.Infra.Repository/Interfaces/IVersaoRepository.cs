using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IVersaoRepository
    {
        Task<Versao> Get();
    }
}
