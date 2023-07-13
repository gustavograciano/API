using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using System.Net;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Core.Helpers;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Models;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Integration.Interfaces;
using WMS.Sisdep.Infra.Integration.Response;
using WMS.Sisdep.Infra.Middleware;


namespace WMS.Sisdep.Application.Services
{
    public class AutenticarApplicationService : IAutenticarApplicationService
    {
        private readonly IAutenticarDomainService _autenticarService;
        private readonly IConfiguration _configuration;
        private readonly IIntegrationAuthorizeClientService _integrationAuthorizeClient;
        public AutenticarApplicationService(
            IAutenticarDomainService autenticarService,
            IConfiguration configuration,
            IIntegrationAuthorizeClientService integrationAuthorizeClient
        )
        {
            _autenticarService = autenticarService;
            _integrationAuthorizeClient = integrationAuthorizeClient;
            _configuration = configuration;
        }

        public async Task<LoginDTO> Login(LoginBody body)
        {
            LoginBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            UsuarioModel usuario = await _autenticarService.Login(body);
            if (usuario == null)
                throw new CustomException("Unauthorized", (int)HttpStatusCode.Unauthorized, "Usuário ou senha inválidos.");

            if (body.Grupo?.ToUpper() != _configuration["Grupo"].ToUpper())
                throw new CustomException("Unauthorized", (int)HttpStatusCode.Unauthorized, "Usuário ou senha inválidos.");

            if (body.Usuario?.ToUpper() != "SUPER" && body.Usuario?.ToUpper() != "ADMIN")
            {
                if (usuario.UsuarioEmpresa.SingleOrDefault(x => x.Empresa.RazaoSocial.Equals(body.Empresa)) == null)
                    throw new CustomException("Unauthorized", (int)HttpStatusCode.Unauthorized, "Usuário ou senha inválidos.");

                await _integrationAuthorizeClient.AddSession(new() { Grupo = body.Grupo, Empresa = body.Empresa, Usuario = usuario.Usuario });
            }

            LoginDTO response = new();
            response.Token = TokenHelper.Generate(usuario, body.Grupo, body.Empresa, _configuration);

            return response;
        }

        public async Task Logout(LogoutBody body)
        {
            LogoutBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            if (!TokenHelper.Check(body.Token))
                throw new CustomException("Invalid Token", (int)HttpStatusCode.BadRequest, "Token ilegível");

            var decodeToken = TokenHelper.Decode(body.Token).Claims.ToList();
            string grupo = decodeToken.Single(x => x.Type.Equals("grupo")).Value;
            string empresa = decodeToken.Single(x => x.Type.Equals("empresa")).Value;
            string usuario = decodeToken.Single(x => x.Type.Equals("usuario")).Value;

            await _integrationAuthorizeClient.DeleteSession(new() { Grupo = grupo, Empresa = empresa, Usuario = usuario });
        }
    }
}
