using AutoMapper;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Integration.Interfaces;

namespace WMS.Sisdep.Application.Services
{
    public class ConfigApplicationService : IConfigApplicationService
    {
        private readonly IIntegrationAuthorizeClientService _integrationAuthorizeClient;
        private readonly IVersaoDomainService _versaoService;
        private readonly IMapper _mapper;

        public ConfigApplicationService(
            IIntegrationAuthorizeClientService integrationAuthorizeClient,
            IVersaoDomainService versaoService,
            IMapper mapper
        )
        {
            _integrationAuthorizeClient = integrationAuthorizeClient;
            _versaoService = versaoService;
            _mapper = mapper;
        }
        public async Task<ObterInformacaoGrupoDTO> GetInformation(string grupo)
        {
            return new ObterInformacaoGrupoDTO()
            {
                ListarEmpresa = await _integrationAuthorizeClient.GetCompanyByNameGroup(grupo),
                Versao = _mapper.Map<VersaoDTO>(await _versaoService.Get())
            };
        }
    }
}
