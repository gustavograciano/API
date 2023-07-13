using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Infra.OldData.Context;
using WMS.Sisdep.Infra.OldData.Entities;
using WMS.Sisdep.Infra.OldData.Interfaces;

namespace WMS.Sisdep.Infra.OldData.Repositories
{
    public class UsuarioOldRepository: IUsuarioOldRepository
    {
        private readonly OldDataContext _context;
        public UsuarioOldRepository(OldDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsuarioOld>> GetAll()
        {
            return await _context.TAB_PASW.ToListAsync();
        }
    }
}
