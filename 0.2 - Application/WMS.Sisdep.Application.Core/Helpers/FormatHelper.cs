namespace WMS.Sisdep.Application.Core.Helpers
{
    public static class FormatHelper
    {
        public static string CNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
                return string.Empty;

            if (cnpj.Length != 14)
                return string.Empty;

            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
        }

        public static string CPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return string.Empty;

            if (cpf.Length != 11)
                return string.Empty;

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
        public static string CEP(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return string.Empty;

            if (cep.Length != 8)
                return string.Empty;

            return Convert.ToUInt64(cep).ToString(@"00\-000\.000");
        }
    }
}
