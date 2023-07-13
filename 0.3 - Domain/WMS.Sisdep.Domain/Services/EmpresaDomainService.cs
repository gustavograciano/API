using AutoMapper;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Domain.Services
{
    public class EmpresaDomainService : IEmpresaDomainService
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IMapper _mapper;
        public EmpresaDomainService(
            IEmpresaRepository empresaRepository,
            IMapper mapper
        )
        {
            _empresaRepository = empresaRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedBaseModel<EmpresaModel>> GetAllWithPaginated(EmpresaQuery query)
        {
            return _mapper.Map<PaginatedBaseModel<EmpresaModel>>(await _empresaRepository.GetAllWithPaginated(query));
        }
    }
}
