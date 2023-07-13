using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/usuario")]
    //[Authorize]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplicationService _usuarioService;
        public UsuarioController(IUsuarioApplicationService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        /// <summary>
        /// Listar usuário V1.
        /// </summary>
        [HttpGet("v1")]
        public async Task<IActionResult> GetOld()
        {
            return Ok(await _usuarioService.GetAllOld());
        }

        /// <summary>
        /// Adicionar Usuario
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] UsuarioBody body)
        {
            await _usuarioService.Add(body);
            return new ObjectResult(body) { StatusCode = StatusCodes.Status201Created };
        }

        /// <summary>
        /// Listar usuário V2.
        /// </summary>
        [HttpGet("v2")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _usuarioService.GetAll());
        }

        /// <summary>
        /// Lista Usuario Pag.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllWithPaginated([FromQuery] UsuarioQuery query)
        {
            return Ok(await _usuarioService.GetAllWithPaginated(query));
        }

        /// <summary>
        /// Obter Usuario.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _usuarioService.GetById(id));
        }

        /// <summary>
        /// Editar Usuario.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UsuarioBody body)
        {
            await _usuarioService.Update(id, body);
            return Ok(body);
        }

        /// <summary>
        /// Remover Usuario.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _usuarioService.Remove(id);
            return Ok();
        }
    }
}
