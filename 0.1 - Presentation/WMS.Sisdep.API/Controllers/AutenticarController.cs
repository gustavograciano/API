using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/autenticar")]
    [AllowAnonymous]
    [ApiController]
    public class AutenticarController : ControllerBase
    {
        private readonly IAutenticarApplicationService _autenticarService;
        public AutenticarController(IAutenticarApplicationService autenticarService)
        {
            _autenticarService = autenticarService;
        }

        /// <summary>
        /// Autenticar usuario.
        /// </summary>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginBody body)
        {
            return Ok(await _autenticarService.Login(body));
        }

        /// <summary>
        /// Logout usuario.
        /// </summary>
        [HttpPost("logout")]
        public async Task<IActionResult> Logout(LogoutBody body)
        {
            await _autenticarService.Logout(body);
            return Ok();
        }
    }
}
