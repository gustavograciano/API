using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Infra.Repository.Interfaces
{
    public interface IPermissaoRepository : IRepositoryBase<Permissao>
    {
        Task<PaginatedBase<Permissao>> GetAllWithPaginated(PermissaoQuery query);
    }
}
