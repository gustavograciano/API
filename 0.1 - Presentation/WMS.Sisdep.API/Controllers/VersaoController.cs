using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/versao")]
    [ApiController]
    public class VersaoController : ControllerBase
    {
        private readonly IVersaoApplicationService _versaoService;
        public VersaoController(IVersaoApplicationService versaoService)
        {
            _versaoService = versaoService;
        }

        /// <summary>
        /// Obter versão
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _versaoService.Get());
        }
    }
}
