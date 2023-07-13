namespace WMS.Sisdep.Domain.Core.Models
{
    public class UsuarioModel : BaseModel
    {
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public bool? PermiteAlterarArquivos { get; set; }
        public bool? QuedaInatividade { get; set; }
        public bool? PermiteAlterarEquipes { get; set; }
        public bool? PermiteAlterarNotaFiscal { get; set; }
        public Guid PerfilId { get; set; }
        public virtual ICollection<UsuarioEmpresaModel> UsuarioEmpresa { get; set; }

    }
}
