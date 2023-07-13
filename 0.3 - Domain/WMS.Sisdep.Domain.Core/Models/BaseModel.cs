namespace WMS.Sisdep.Domain.Core.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaAlteracao { get; set; }
    }
}
