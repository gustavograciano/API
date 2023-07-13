using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/empresa")]
    //[Authorize]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaApplicationService _empresaService;
        public EmpresaController(IEmpresaApplicationService empresaService)
        {
            _empresaService = empresaService;
        }

        /// <summary>
        /// Lista Empresas
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllWithPaginated([FromQuery] EmpresaQuery query)
        {
            return Ok(await _empresaService.GetAllWithPaginated(query));
        }
    }
}
