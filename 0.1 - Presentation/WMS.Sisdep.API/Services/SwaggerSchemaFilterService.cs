using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using WMS.Sisdep.Domain.Core.Bodies;

namespace WMS.Sisdep.API.Services
{
    public class SwaggerSchemaFilterService : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type == typeof(LoginBody))
            {
                schema.Example = new LoginBodySchema().GetExample();
            }

            if (context.Type == typeof(LogoutBody))
            {
                schema.Example = new LogoutBodySchema().GetExample();
            }

            if (context.Type == typeof(UsuarioBody))
            {
                schema.Example = new UsuarioBodySchema().GetExample();
            }

            if (context.Type == typeof(EmpresaBody))
            {
                schema.Example = new EmpresaBodySchema().GetExample();
            }

            if (context.Type == typeof(PerfilBody))
            {
                schema.Example = new PerfilBodySchema().GetExample();
            }
            if (context.Type == typeof(PermissaoBody))
            {
                schema.Example = new PermissaoBodySchema().GetExample();
            }
        }
    }
}
