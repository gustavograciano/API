using AutoMapper;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Domain.Core.AutoMappers
{
    public class EntityToModel : Profile
    {
        public EntityToModel()
        {
            CreateMap<Usuario, UsuarioModel>()
                .ForMember(dest => dest.Usuario, m => m.MapFrom(a => a.UsuarioNome));
            CreateMap<PaginatedBase<Usuario>, PaginatedBaseModel<UsuarioModel>>();

            CreateMap<Empresa, EmpresaModel>();
            CreateMap<PaginatedBase<Empresa>, PaginatedBaseModel<EmpresaModel>>();
            CreateMap<UsuarioEmpresa, UsuarioEmpresaModel>();
            CreateMap<Versao, VersaoModel>();
            CreateMap<Perfil, PerfilModel>();
            CreateMap<PaginatedBase<Perfil>, PaginatedBaseModel<PerfilModel>>();
            CreateMap<Permissao, PermissaoModel>();
            CreateMap<PaginatedBase<Permissao>, PaginatedBaseModel<PermissaoModel>>();
        }
    }
}
