using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Infra.Integration.Interfaces;
using WMS.Sisdep.Infra.Integration.Response;
using WMS.Sisdep.Infra.Middleware;

namespace WMS.Sisdep.Infra.Integration.Services
{
    public class IntegrationAuthorizeClientService : IIntegrationAuthorizeClientService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient client;
        private string url = string.Empty;
        public IntegrationAuthorizeClientService(IConfiguration configuration)
        {
            client = new HttpClient();
            _configuration = configuration;
            url = configuration["Integration:AuthorizeCliente"];
        }

        public async Task<LoginResponse> Login(LoginBody body)
        {
            string dataJson = JsonConvert.SerializeObject(body);
            StringContent data = new(dataJson, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponse = await client.PostAsync($"{url}/autenticar/login", data);

            if (httpResponse.IsSuccessStatusCode)
            {
                LoginResponse result =
                    JsonConvert.DeserializeObject<LoginResponse>(httpResponse.Content.ReadAsStringAsync().Result);
                return result;
            }
            else
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                throw new NotImplementedException();
            }
        }

        public async Task AddSession(SessaoBody body)
        {
            string dataJson = JsonConvert.SerializeObject(body);
            StringContent data = new(dataJson, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponse = await client.PostAsync($"{url}/sessao", data);

            if (httpResponse.IsSuccessStatusCode)
            {
                return;
            }
            else
            {
                ErrorResponse result = JsonConvert.DeserializeObject<ErrorResponse>(httpResponse.Content.ReadAsStringAsync().Result);
                throw new CustomException(result.Errors.Title, result.Errors.Status, result.Errors.Detail);
            }
        }

        public async Task DeleteSession(SessaoBody body)
        {
            string dataJson = JsonConvert.SerializeObject(body);
            StringContent data = new(dataJson, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = data,
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{url}/sessao")
            };

            HttpResponseMessage httpResponse = await client.SendAsync(request);

            if (httpResponse.IsSuccessStatusCode)
            {
                return;
            }
            else
            {
                ErrorResponse result = JsonConvert.DeserializeObject<ErrorResponse>(httpResponse.Content.ReadAsStringAsync().Result);
                throw new CustomException(result.Errors.Title, result.Errors.Status, result.Errors.Detail);
            }
        }

        public async Task<IEnumerable<ListarEmpresaResponse>> GetCompanyByNameGroup(string grupo)
        {
            //client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token));

            HttpResponseMessage httpResponse =
                await client.GetAsync($"{url}/empresa/listarPorNomeGrupo/{grupo}");

            if (httpResponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ListarEmpresaResponse>>(httpResponse.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public async Task<ObterBancoDadosResponse> GetDatabaseWithFilter(string grupo, string empresa)
        {
            //client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token));

            HttpResponseMessage httpResponse =
                await client.GetAsync($"{url}/bancoDeDados/obter/{grupo}/{empresa}");

            if (httpResponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ObterBancoDadosResponse>(httpResponse.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
