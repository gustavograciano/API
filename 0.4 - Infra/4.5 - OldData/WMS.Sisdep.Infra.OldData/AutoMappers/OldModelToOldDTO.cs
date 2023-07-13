using AutoMapper;
using WMS.Sisdep.Infra.OldData.DTOs;
using WMS.Sisdep.Infra.OldData.Models;

namespace WMS.Sisdep.Infra.OldData.AutoMappers
{
    public class OldModelToOldDTO : Profile
    {
        public OldModelToOldDTO()
        {
            CreateMap<UsuarioOldModel, UsuarioOldDTO>();
        }
    }
}
