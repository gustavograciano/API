namespace WMS.Sisdep.Infra.Data.Entities
{
    public class Permissao : Base
    {
        public string? TelaReferencia { get; set; }
        public bool? PermiteVisualizar { get; set; }
        public bool? PermiteEditar { get; set; }
        public bool? PermiteInativar { get; set; }
        public bool? PermiteAdicionar { get; set; }
        public Guid PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        
    }
}
