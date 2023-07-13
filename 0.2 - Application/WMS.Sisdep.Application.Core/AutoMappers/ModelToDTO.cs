using AutoMapper;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Core.Helpers;
using WMS.Sisdep.Domain.Core.Models;

namespace WMS.Sisdep.Application.Core.AutoMappers
{
    public class ModelToDTO : Profile
    {
        public ModelToDTO()
        {
            CreateMap<UsuarioModel, UsuarioDTO>();
            CreateMap<PaginatedBaseModel<UsuarioModel>, PaginatedBaseDTO<UsuarioDTO>>();
            CreateMap<EmpresaModel, EmpresaDTO>()
                .ForMember(dest => dest.CNPJ, m => m.MapFrom(a => FormatHelper.CNPJ(a.CNPJ)))
                .ForMember(dest => dest.CEP, m => m.MapFrom(a => FormatHelper.CEP(a.CEP)));
            CreateMap<PaginatedBaseModel<EmpresaModel>, PaginatedBaseDTO<EmpresaDTO>>();
            CreateMap<VersaoModel, VersaoDTO>();
            CreateMap<PerfilModel, PerfilDTO>();
            CreateMap<PaginatedBaseModel<PerfilModel>, PaginatedBaseDTO<PerfilDTO>>();
            CreateMap<PermissaoModel, PermissaoDTO>();
            CreateMap<PaginatedBaseModel<PermissaoModel>, PaginatedBaseDTO<PermissaoDTO>>();
        }
    }
}
