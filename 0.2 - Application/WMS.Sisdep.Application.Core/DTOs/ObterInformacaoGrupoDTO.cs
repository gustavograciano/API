namespace WMS.Sisdep.Application.Core.DTOs
{
    public class ObterInformacaoGrupoDTO
    {
        public IEnumerable<object>? ListarEmpresa { get; set; }
        public VersaoDTO? Versao { get; set; }
    }
}
