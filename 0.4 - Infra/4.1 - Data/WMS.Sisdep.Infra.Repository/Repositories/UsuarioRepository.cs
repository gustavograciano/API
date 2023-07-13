using Microsoft.EntityFrameworkCore;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        private readonly SqlContext _context;
        public UsuarioRepository(SqlContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> GetByUser(LoginBody body)
        {
            IQueryable<Usuario> query = _context.Usuario
                .Include(x => x.UsuarioEmpresa)
                .ThenInclude(x => x.Empresa);

            return await query
                .SingleOrDefaultAsync(
                    x => x.UsuarioNome.Equals(body.Usuario.ToUpper()) &&
                    x.Senha.Equals(body.Senha));
        }
        public async Task<PaginatedBase<Usuario>> GetAllWithPaginated(UsuarioQuery query)
        {
            IQueryable<Usuario> data = _context.Usuario;

            if (!string.IsNullOrEmpty(query.Nome))
            {
                data = data.Where(x => x.Nome.ToUpper().Contains(query.Nome));
            }

            return await PaginatedBase<Usuario>.CreateAsync(data, query.Page, query.Quantity);
        }

        public async Task AddUsuarioEmpresa(UsuarioEmpresa usuarioEmpresa)
        {
            _context.Set<UsuarioEmpresa>().Add(usuarioEmpresa);
            await _context.SaveChangesAsync();
        }
    }
}
