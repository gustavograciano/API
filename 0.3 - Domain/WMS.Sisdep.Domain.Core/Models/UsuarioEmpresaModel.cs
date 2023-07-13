namespace WMS.Sisdep.Domain.Core.Models
{
    public class UsuarioEmpresaModel
    {
        public Guid UsuarioId { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
        public Guid EmpresaId { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
    }
}
