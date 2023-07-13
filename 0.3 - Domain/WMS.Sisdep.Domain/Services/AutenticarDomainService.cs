using AutoMapper;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Domain.Services
{
    public class AutenticarDomainService : IAutenticarDomainService
    {
        private readonly IAutenticarRepository _autenticarRepository;
        private readonly IMapper _mapper;

        public AutenticarDomainService(
            IAutenticarRepository autenticarRepository,
            IMapper mapper
        )
        {
            _autenticarRepository = autenticarRepository;
            _mapper = mapper;
        }
        public async Task<UsuarioModel> Login(LoginBody body)
        {
            return _mapper.Map<UsuarioModel>(await _autenticarRepository.GetByUser(body)); ;
        }
    }
}
