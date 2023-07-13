using AutoMapper;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Interfaces;

namespace WMS.Sisdep.Application.Services
{
    public class VersaoApplicationService: IVersaoApplicationService
    {
        private readonly IVersaoDomainService _versaoService;
        private readonly IMapper _mapper;
        public VersaoApplicationService(
            IVersaoDomainService versaoService,
            IMapper mapper
        )
        {
            _versaoService = versaoService;
            _mapper = mapper;
        }

        public async Task<VersaoDTO> Get()
        {
            return _mapper.Map<VersaoDTO>(await _versaoService.Get());
        }

    }
}
