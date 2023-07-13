using AutoMapper;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Domain.Services
{
    public class VersaoDomainService : IVersaoDomainService
    {
        private readonly IVersaoRepository _versaoRepository;
        private readonly IMapper _mapper;
        public VersaoDomainService(
            IVersaoRepository versaoRepository,
            IMapper mapper
        )
        {
            _versaoRepository = versaoRepository;
            _mapper = mapper;
        }
        public async Task<VersaoModel> Get()
        {
            return _mapper.Map<VersaoModel>(await _versaoRepository.Get());
        }
    }
}
