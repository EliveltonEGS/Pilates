using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Especialidade;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseEspecialidade
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadeController : ControllerBase
    {

        private readonly IApplicationServiceEspecialidade _applicationServiceEspecialidade;

        public EspecialidadeController(IApplicationServiceEspecialidade applicationServiceEspecialidade)
        {
            _applicationServiceEspecialidade = applicationServiceEspecialidade;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<EspecialidadeDTO>> Get()
        {
            return Ok(await _applicationServiceEspecialidade.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<EspecialidadeDTO> Get(Guid id)
        {
            return Ok(_applicationServiceEspecialidade.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<EspecialidadeDTO> Post([FromBody] EspecialidadeDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceEspecialidade.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<EspecialidadeDTO> Put(Guid id, [FromBody] EspecialidadeDTO input)
        {
            if (input == null || input.EspecialidadeId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceEspecialidade.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<EspecialidadeDTO> Delete(Guid id)
        {
            _applicationServiceEspecialidade.DeleteById(id);
            return Ok("Removido");
        }
    }
}
