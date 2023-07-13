using FluentValidation;
using Microsoft.OpenApi.Any;

namespace WMS.Sisdep.Domain.Core.Bodies
{
    public class LogoutBody
    {
        public string? Token { get; set; }
    }
    public class LogoutBodyValidator : AbstractValidator<LogoutBody>
    {
        public LogoutBodyValidator()
        {
            RuleFor(login => login.Token)
                .NotEmpty()
                .NotNull();
        }
    }

    public class LogoutBodySchema
    {
        public OpenApiObject GetExample()
        {
            return new OpenApiObject()
            {
                ["token"] = new OpenApiString("")
            };
        }
    }
}
