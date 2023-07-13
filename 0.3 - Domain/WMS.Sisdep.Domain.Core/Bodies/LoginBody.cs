using FluentValidation;
using Microsoft.OpenApi.Any;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class LoginBody
    {
        public string? Grupo { get; set; }
        public string? Empresa { get; set; }
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
    }

    public class LoginBodyValidator : AbstractValidator<LoginBody>
    {
        public LoginBodyValidator()
        {
            RuleFor(login => login.Grupo)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.Empresa)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.Usuario)
                .NotEmpty()
                .NotNull();

            RuleFor(login => login.Senha)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5);
        }
    }

    public class LoginBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["grupo"] = new OpenApiString("NEMAG"),
                ["empresa"] = new OpenApiString("NEMAG INFORMÁTICA LTDA"),
                ["usuario"] = new OpenApiString("SUPER"),
                ["senha"] = new OpenApiString("12345"),
            };
        }

    }
}
