using FluentValidation;
using Microsoft.OpenApi.Any;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class PerfilBody
    {
        public string? Nome { get; set; }
    }

    public class PerfilBodyValidator : AbstractValidator<PerfilBody>
    {
        public PerfilBodyValidator()
        {
            RuleFor(login => login.Nome)
                .NotEmpty()
                .NotNull();
        }
    }

    public class PerfilBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["nome"] = new OpenApiString("Coodernador")
            };
        }

    }
}
