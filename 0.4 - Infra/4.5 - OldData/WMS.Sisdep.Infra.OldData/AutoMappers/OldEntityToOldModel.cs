using AutoMapper;
using WMS.Sisdep.Infra.OldData.Entities;
using WMS.Sisdep.Infra.OldData.Models;

namespace WMS.Sisdep.Infra.OldData.AutoMappers
{
    public class OldEntityToOldModel : Profile
    {
        public OldEntityToOldModel()
        {
            CreateMap<UsuarioOld, UsuarioOldModel>();
        }
    }
}
