using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        Task Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update( TEntity obj);
        Task Remove(TEntity obj);
    }
}
