using FluentValidation.Results;
using System.Net;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Integration.Interfaces;
using WMS.Sisdep.Infra.Integration.Response;
using WMS.Sisdep.Infra.Middleware;

namespace WMS.Sisdep.Application.Services
{
    public class AuthorizeClientApplicationService : IAuthorizeClientApplicationService
    {
        private readonly IIntegrationAuthorizeClientService _integrationAuthorizeClient;
        public AuthorizeClientApplicationService(IIntegrationAuthorizeClientService integrationAuthorizeClient)
        {
            _integrationAuthorizeClient = integrationAuthorizeClient;
        }
        public async Task<LoginResponse> Login(LoginBody body)
        {
            LoginBodyValidator validator = new LoginBodyValidator();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            return await _integrationAuthorizeClient.Login(body);
        }

        public async Task AddSession(SessaoBody body)
        {
            await _integrationAuthorizeClient.AddSession(body);
        }

        public async Task<IEnumerable<ListarEmpresaResponse>> GetCompanyByNameGroup(string grupo)
        {
            return await _integrationAuthorizeClient.GetCompanyByNameGroup(grupo);
        }
    }
}
