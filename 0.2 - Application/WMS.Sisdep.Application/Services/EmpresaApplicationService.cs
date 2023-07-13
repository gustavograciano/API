using AutoMapper;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;

namespace WMS.Sisdep.Application.Services
{
    public class EmpresaApplicationService : IEmpresaApplicationService
    {
        private readonly IEmpresaDomainService _empresaService;
        private readonly IMapper _mapper;
        public EmpresaApplicationService(
            IEmpresaDomainService empresaService,
            IMapper mapper
        )
        {
            _empresaService = empresaService;
            _mapper = mapper;
        }

        public async Task<PaginatedBaseDTO<EmpresaDTO>> GetAllWithPaginated(EmpresaQuery query)
        {
            return _mapper.Map<PaginatedBaseDTO<EmpresaDTO>>(await _empresaService.GetAllWithPaginated(query));
        }
    }
}
