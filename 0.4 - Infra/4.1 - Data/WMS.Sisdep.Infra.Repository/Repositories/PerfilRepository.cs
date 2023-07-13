using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class PerfilRepository : RepositoryBase<Perfil>, IPerfilRepository
    {
        private readonly SqlContext _context;
        public PerfilRepository(SqlContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PaginatedBase<Perfil>> GetAllWithPaginated(PerfilQuery query)
        {
            IQueryable<Perfil> data = _context.Perfil;

            if (!string.IsNullOrEmpty(query.Nome))
            {
                data = data.Where(x => x.Nome.ToUpper().Contains(query.Nome));
            }

            return await PaginatedBase<Perfil>.CreateAsync(data, query.Page, query.Quantity);
        }
    }
}
