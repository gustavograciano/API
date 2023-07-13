using Microsoft.AspNetCore.Mvc;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;

namespace WMS.Sisdep.API.Controllers
{
    [Route("api/permissao")]
    //[Authorize]
    [ApiController]
    public class PermissaoController : ControllerBase
    {
        private readonly IPermissaoApplicationService _permissaoService;

        public PermissaoController(IPermissaoApplicationService permissaoService)
        {
            _permissaoService = permissaoService;
        }
        /// <summary>
        /// Listar Permissao.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllWithPaginated([FromQuery] PermissaoQuery query)
        {
            return Ok(await _permissaoService.GetAllWithPaginated(query));
        }

        /// <summary>
        /// Obter Permissao.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _permissaoService.GetById(id));
        }

        /// <summary>
        /// Adicionar Permissao.
        /// </summary>
        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] PermissaoBody body)
        {
            if(body.PermiteVisualizar == false)
            {
                body.PermiteEditar = false;
                body.PermiteAdicionar = false;
                body.PermiteInativar = false;

            }
            await _permissaoService.Add(body);
            return new ObjectResult(body) { StatusCode = StatusCodes.Status201Created };
        }

        /// <summary>
        /// Editar Permissao.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] PermissaoBody body)
        {
            if (body.PermiteVisualizar == false)
            {
                body.PermiteEditar = false;
                body.PermiteAdicionar = false;
                body.PermiteInativar = false;

            }
            await _permissaoService.Update(id, body);
            return Ok(body);
        }

        /// <summary>
        /// Remover Permissao.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _permissaoService.Remove(id);
            return Ok();
        }

    }
}
