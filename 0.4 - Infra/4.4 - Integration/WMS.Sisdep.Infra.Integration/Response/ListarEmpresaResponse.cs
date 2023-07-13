namespace WMS.Sisdep.Infra.Integration.Response
{
    public class ListarEmpresaResponse
    {
        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Logo { get; set; }
        public string? CaminhoLogo { get; set; }
        public bool? Ativo { get; set; }
        public int? LicencaDesktop { get; set; }
        public int? LicencaColetorRF { get; set; }
        public int? LicencaDepositante { get; set; }
    }
}
