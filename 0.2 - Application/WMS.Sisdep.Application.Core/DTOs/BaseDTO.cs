namespace WMS.Sisdep.Application.Core.DTOs
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaAlteracao { get; set; }
    }
}
