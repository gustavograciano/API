namespace WMS.Sisdep.Infra.Data.Entities
{
    public class Perfil : Base
    {
        public string? Nome { get; set; }
        public virtual ICollection<Permissao> Permissao { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }


    }
}
