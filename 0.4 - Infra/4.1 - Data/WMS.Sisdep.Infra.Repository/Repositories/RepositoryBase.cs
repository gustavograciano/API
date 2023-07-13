using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;
        public RepositoryBase(SqlContext context)
        {
            _context = context;
        }

        public async Task Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity obj)
        {
            _context.Set<TEntity>().Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}
