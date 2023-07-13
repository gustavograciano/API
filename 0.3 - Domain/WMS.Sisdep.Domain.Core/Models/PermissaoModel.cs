using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Domain.Core.Models
{
    public class PermissaoModel : BaseModel
    {
        public string TelaReferencia { get; set; }
        public bool? PermiteVisualizar { get; set; }
        public bool? PermiteEditar { get; set; }
        public bool? PermiteInativar { get; set; }
        public bool? PermiteAdicionar { get; set; }

        public virtual PerfilModel Perfil { get; set; }
        public Guid PerfilId { get; set; }

        public virtual UsuarioModel Usuario { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
