using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Domain.Interfaces
{
    public interface IPermissaoDomainService 
    {
        Task<PaginatedBaseModel<PermissaoModel>> GetAllWithPaginated(PermissaoQuery query);
        
        Task Add(PermissaoBody body);
        Task<IEnumerable<PermissaoModel>> GetAll();
        Task<PermissaoModel> GetById(Guid id);
        Task Update(Guid id, PermissaoBody body);
        Task Remove(Guid id);
    }
}
