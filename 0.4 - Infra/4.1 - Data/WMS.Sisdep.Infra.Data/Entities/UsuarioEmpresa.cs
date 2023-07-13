namespace WMS.Sisdep.Infra.Data.Entities
{
    public class UsuarioEmpresa : Base
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Guid EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
