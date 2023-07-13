using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class PermissaoRepository : RepositoryBase<Permissao>, IPermissaoRepository
    {
        private readonly SqlContext _context;

        public PermissaoRepository(SqlContext context) : base(context)
        {      
              _context = context;
            
        }

        public async Task<PaginatedBase<Permissao>> GetAllWithPaginated(PermissaoQuery query)
        {
            IQueryable<Permissao> permissao = _context.Permissao;

            if (!string.IsNullOrEmpty(query.TelaReferencia))
            {
                permissao = permissao.Where(x => x.TelaReferencia.ToUpper().Contains(query.TelaReferencia));
            }

            return await PaginatedBase<Permissao>.CreateAsync(permissao, query.Page, query.Quantity);
        }
    }
}
