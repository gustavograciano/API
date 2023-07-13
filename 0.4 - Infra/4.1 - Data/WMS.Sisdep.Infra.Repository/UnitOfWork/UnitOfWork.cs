using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlContext _context;
        public UnitOfWork(SqlContext context)
        {
            _context = context;
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
