using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Domain.Core.Models;

namespace WMS.Sisdep.Application.Core.DTOs
{
    public class PermissaoDTO
    {
        public string? TelaReferencia { get; set; }
        public bool? PermiteVisualizar { get; set; }
        public bool? PermiteEditar { get; set; }
        public bool? PermiteInativar { get; set; }
        public bool? PermiteAdicionar { get; set; }
        public Guid PerfilId { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
