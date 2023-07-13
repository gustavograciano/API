using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/config")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfigApplicationService _configService;
        public ConfigController(IConfigApplicationService configService)
        {
            _configService = configService;
        }

        /// <summary>
        /// Obter Informações de Configuração do Grupo
        /// </summary>
        [HttpGet("obterInformacao/{grupo}")]
        public async Task<IActionResult> GetInformation(string grupo)
        {
            return Ok(await _configService.GetInformation(grupo));
        }
    }
}
