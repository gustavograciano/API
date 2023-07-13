using WMS.Sisdep.Infra.OldData.Entities;

namespace WMS.Sisdep.Infra.OldData.Interfaces
{
    public interface IUsuarioOldRepository
    {
        Task<IEnumerable<UsuarioOld>> GetAll();
    }
}
