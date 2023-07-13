
namespace WMS.Sisdep.Application.Core.DTOs
{
    public class EmpresaDTO 
    {
        public string? RazaoSocial { get; set; }
        public string? Endereço { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? CNPJ { get; set; }
        public int? IE { get; set; }
        public string? UF { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? NomeServidor { get; set; }
        public int? PortaServidor { get; set; }
        public bool? RequerAutenticacao { get; set; }
        public string? UsuarioServidor { get; set; }
        public string? SenhaServidor { get; set; }
    }
}
