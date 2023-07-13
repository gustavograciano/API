namespace WMS.Sisdep.Infra.Data.Entities
{
    public class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
        public DateTime UltimaAlteracao { get; set; } = DateTime.UtcNow;
    }
}
