using FluentValidation;
using Microsoft.OpenApi.Any;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Infra.Data.Entities;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class PermissaoBody 
    {
        public string? TelaReferencia { get; set; }
        public bool? PermiteVisualizar { get; set; }
        public bool? PermiteEditar { get; set; }
        public bool? PermiteInativar { get; set; }
        public bool? PermiteAdicionar { get; set; }
        public Guid PerfilId { get; set; }
        public Guid UsuarioId { get; set; }
    }
    public class PermissaoBodyValidator : AbstractValidator<PermissaoBody>
    {
        public PermissaoBodyValidator()
        {
            RuleFor(login => login.TelaReferencia)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.PermiteVisualizar)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.PermiteEditar)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.PermiteInativar)
                .NotEmpty()
                .NotNull();
            RuleFor(login => login.PermiteAdicionar)
               .NotEmpty()
               .NotNull();
            RuleFor(login => login.PerfilId)
               .NotEmpty()
               .NotNull();
            RuleFor(login => login.UsuarioId)
               .NotEmpty()
               .NotNull();
        }
    }

    public class PermissaoBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["telaReferencia"] = new OpenApiString("NEMAG"),
                ["permiteVisualizar"] = new OpenApiBoolean(true),
                ["permiteEditar"] = new OpenApiBoolean(true),
                ["permiteInativar"] = new OpenApiBoolean(true),
                ["permiteAdicionar"] = new OpenApiBoolean(true),
                ["perfilId"] = new OpenApiString("3FD34B96-F0DE-430F-838A-03BAB572A776"),
                ["usuarioId"] = new OpenApiString("CBB492DC-AA21-40C0-AA85-ABB581F55F81"),


            };
        }

    }
}
