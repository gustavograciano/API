using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Data.Entities;
using WMS.Sisdep.Infra.Repository.Interfaces;

namespace WMS.Sisdep.Infra.Repository.Repositories
{
    public class AutenticarRepository : IAutenticarRepository
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AutenticarRepository(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<Usuario> GetByUser(LoginBody body)
        {
            return await _usuarioRepository.GetByUser(body);
        }

    }
}
