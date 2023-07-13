using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.Application.Interfaces
{
    public interface IPermissaoApplicationService 
    {
        Task<PaginatedBaseDTO<PermissaoDTO>> GetAllWithPaginated(PermissaoQuery query);
        Task Add(PermissaoBody body);
        Task<IEnumerable<PermissaoDTO>> GetAll();
        Task<PermissaoDTO> GetById(Guid id);
        Task Update(Guid id , PermissaoBody permissaoBody);
        Task Remove(Guid id);
    }
}
