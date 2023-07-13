using AutoMapper;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Domain.Core.AutoMappers
{
    public class BodyToEntity : Profile
    {
        public BodyToEntity()
        {
            CreateMap<UsuarioBody, Usuario>()
                .AfterMap((s, d) =>
                {
                    d.UsuarioNome = s.Usuario.ToUpper();
                });

            CreateMap<PerfilBody, Perfil>();
            CreateMap<PermissaoBody, Permissao>();
        }
    }
}
