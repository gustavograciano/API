using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/authorizeClient")]
    [ApiController]
    public class AuthorizeClientController : ControllerBase
    {
        private readonly IAuthorizeClientApplicationService _authorizeClientService;
        public AuthorizeClientController(IAuthorizeClientApplicationService authorizeClientService)
        {
            _authorizeClientService = authorizeClientService;
        }

        /// <summary>
        /// Autenticar usuario pelo Authorize Cliente.
        /// </summary>
        [HttpPost("autenticar/login")]
        public async Task<IActionResult> Login([FromBody] LoginBody body)
        {
            return Ok(await _authorizeClientService.Login(body));
        }

        /// <summary>
        /// Listar empresas com filtro grupo pelo Authorize Cliente.
        /// </summary>
        [HttpGet("empresa/listarPorNomeGrupo/{grupo}")]
        public async Task<IActionResult> GetCompanyByNameGroup(string grupo)
        {
            return Ok(await _authorizeClientService.GetCompanyByNameGroup(grupo));
        }
    }
}
