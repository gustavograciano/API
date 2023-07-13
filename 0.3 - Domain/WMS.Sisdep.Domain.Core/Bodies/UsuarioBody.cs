using FluentValidation;
using Microsoft.OpenApi.Any;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class UsuarioBody
    {
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public bool? PermiteAlterarArquivos { get; set; }
        public bool? QuedaInatividade { get; set; }
        public bool? PermiteAlterarEquipes { get; set; }
        public bool? PermiteAlterarNotaFiscal { get; set; }
        public Guid PerfilId { get; set; }
        public Guid EmpresaId { get; set; }


    }
    public class UsuarioBodyValidator : AbstractValidator<UsuarioBody>
    {
        public UsuarioBodyValidator()
        {
            RuleFor(login => login.Usuario)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.Senha)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5);

            RuleFor(login => login.Nome)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(login => login.PermiteAlterarArquivos)
               .NotEmpty()
               .NotNull();

            RuleFor(login => login.QuedaInatividade)
               .NotEmpty()
               .NotNull();

            RuleFor(login => login.PermiteAlterarEquipes)
               .NotEmpty()
               .NotNull();

            RuleFor(login => login.PermiteAlterarNotaFiscal)
               .NotEmpty()
               .NotNull();
            RuleFor(login => login.PerfilId)
              .NotEmpty()
              .NotNull();
            RuleFor(login => login.EmpresaId)
             .NotEmpty()
             .NotNull();
        }
    }

    public class UsuarioBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["usuario"] = new OpenApiString("PANTOJA"),
                ["senha"] = new OpenApiString("12345"),
                ["nome"] = new OpenApiString("Gabriel Pantoja"),
                ["email"] = new OpenApiString("pantoja@pantoja.com"),
                ["permiteAlterarArquivos"] = new OpenApiBoolean(true),
                ["quedaInatividade"] = new OpenApiBoolean(true),
                ["permiteAlterarEquipes"] = new OpenApiBoolean(true),
                ["permiteAlterarNotaFiscal"] = new OpenApiBoolean(true),
                ["perfilId"] = new OpenApiString("3FD34B96-F0DE-430F-838A-03BAB572A776"),
                ["empresaId"] = new OpenApiString("BF006C54-99FF-4893-9881-0D30EC7406B1"),

            };
        }

    }
}
