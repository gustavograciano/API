using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class VersaoRepository : IVersaoRepository
    {
        private readonly SqlContext _context;
        public VersaoRepository(SqlContext context)
        {
            _context = context;
        }

        public async Task<Versao> Get()
        {
            return await _context.Versao.FirstOrDefaultAsync();
        }
    }
}
