using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/perfil")]
    //[Authorize]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilApplicationService _perfilService;

        public PerfilController(IPerfilApplicationService perfilService)
        {
            _perfilService = perfilService;
        }

        /// <summary>
        /// Listar perfil.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllWithPaginated([FromQuery] PerfilQuery query)
        {
            return Ok(await _perfilService.GetAllWithPaginated(query));
        }

        /// <summary>
        /// Obter perfil.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _perfilService.GetById(id));
        }

        /// <summary>
        /// Adicionar perfil.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] PerfilBody body)
        {
            await _perfilService.Add(body);
            return new ObjectResult(body) { StatusCode = StatusCodes.Status201Created };
        }

        /// <summary>
        /// Editar perfil.
        /// </summary>
        [HttpPut("{id}")]      
        public async Task<IActionResult> Put(Guid id ,[FromBody] PerfilBody body)
        {
            await _perfilService.Update(id,body);
            return Ok(body);
        }

        /// <summary>
        /// Remover perfil.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _perfilService.Remove(id);
            return Ok();
        }

    }
}
