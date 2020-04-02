using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Aula;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAula
{
    [ApiController]
    [Route("[controller]")]
    public class AulaController : ControllerBase
    {

        private readonly IApplicationServiceAula _applicationServiceAula;

        public AulaController(IApplicationServiceAula applicationServiceAula)
        {
            _applicationServiceAula = applicationServiceAula;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<AulaDTO>> Get()
        {
            return Ok(await _applicationServiceAula.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<AulaDTO> Get(Guid id)
        {
            return Ok(_applicationServiceAula.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<AulaDTO> Post([FromBody] AulaDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceAula.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<AulaDTO> Put(Guid id, [FromBody] AulaDTO input)
        {
            if (input == null || input.ProfessorId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceAula.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<AulaDTO> Delete(Guid id)
        {
            _applicationServiceAula.DeleteById(id);
            return Ok("Removido");
        }
    }
}
