namespace WMS.Sisdep.Infra.Data.Entities
{
    public class Usuario : Base
    {
        public string? UsuarioNome { get; set; }
        public string? Senha { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public bool? PermiteAlterarArquivos { get; set; }
        public bool? QuedaInatividade { get; set; }    
        public bool? PermiteAlterarEquipes { get; set; }
        public bool? PermiteAlterarNotaFiscal { get; set; }
        public Guid PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresa { get; set; }
        public virtual ICollection<Permissao> Permissao { get; set; }
    }
}
