using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
    {
        private readonly SqlContext _context;
        public EmpresaRepository(SqlContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PaginatedBase<Empresa>> GetAllWithPaginated(EmpresaQuery query)
        {
            IQueryable<Empresa> data = _context.Empresa;

            if (!string.IsNullOrEmpty(query.RazaoSocial))
            {
                data = data.Where(x => x.RazaoSocial.ToUpper().Contains(query.RazaoSocial));
            }

            return await PaginatedBase<Empresa>.CreateAsync(data, query.Page, query.Quantity);
        }
    }
}
