using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IAutenticarRepository
    {
        Task<Usuario> GetByUser(LoginBody body);
    }
}
