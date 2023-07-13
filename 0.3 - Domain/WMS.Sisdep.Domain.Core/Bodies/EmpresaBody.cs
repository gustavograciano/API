using FluentValidation;
using Microsoft.OpenApi.Any;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class EmpresaBody
    {
        public string? RazaoSocial { get; set; }
        public string? Endereço { get; set; }
        public int? Numero { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? CNPJ { get; set; }
        public string? IE { get; set; }
        public string? UF { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? NomeServidor { get; set; }
        public int? PortaServidor { get; set; }
        public bool? RequerAutenticaçao { get; set; }
        public string? UsuarioServidor { get; set; }
        public string? SenhaServidor { get; set; }

    }
    public class EmpresaBodyValidator : AbstractValidator<EmpresaBody>
    {
        public EmpresaBodyValidator()
        {
            //RuleFor(login => login.UsuarioNome)
            //    .NotEmpty()
            //    .NotNull();

            //RuleFor(login => login.Senha)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(5);

            //RuleFor(login => login.Nome)
            //    .NotEmpty()
            //    .NotNull();

            //RuleFor(login => login.Email)
            //    .NotEmpty()
            //    .NotNull()
            //    .EmailAddress();

            //RuleFor(login => login.PermiteAlterarArquivos)
            //   .NotEmpty()
            //   .NotNull();

            //RuleFor(login => login.QuedaInatividade)
            //   .NotEmpty()
            //   .NotNull();

            //RuleFor(login => login.PermiteAlterarEquipes)
            //   .NotEmpty()
            //   .NotNull();

            //RuleFor(login => login.PermiteAlterarNotaFiscal)
            //   .NotEmpty()
            //   .NotNull();
        }
    }

    public class EmpresaBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["usuarioNome"] = new OpenApiString("PANTOJA"),
                ["senha"] = new OpenApiString("12345"),
                ["nome"] = new OpenApiString("Gabriel Pantoja"),
                ["email"] = new OpenApiString("pantoja@pantoja.com"),
                ["permiteAlterarArquivos"] = new OpenApiBoolean(true),
                ["quedaInatividade"] = new OpenApiBoolean(true),
                ["permiteAlterarEquipes"] = new OpenApiBoolean(true),
                ["permiteAlterarNotaFiscal"] = new OpenApiBoolean(true),
                ["perfil"] = new OpenApiString(""),
            };
        }

    }
}
