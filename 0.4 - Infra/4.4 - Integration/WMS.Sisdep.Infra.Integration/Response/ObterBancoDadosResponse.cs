namespace WMS.Sisdep.Infra.Integration.Response
{
    public class ObterBancoDadosResponse
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Servidor { get; set; }
        public string? Porta { get; set; }
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltimaVerificacao { get; set; }
        public int IdSistema { get; set; }
        public int IdTipoBanco { get; set; }
        public bool CriarBancoSeNaoExistir { get; set; }
    }
}
