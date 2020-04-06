using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Aula;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAula
{
    [ApiController]
    [Route("[controller]")]
    public class AulaController : GenericController<AulaDTO>
    {

        private readonly IApplicationServiceAula _applicationServiceAula;

        public AulaController(IApplicationServiceAula applicationServiceAula)
        {
            _applicationServiceAula = applicationServiceAula;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<AulaDTO> GetAll()
        {
            return Ok(_applicationServiceAula.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<AulaDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceAula.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<AulaDTO> Post([FromBody] AulaDTO input)
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
        public override ActionResult<AulaDTO> Put(Guid id, [FromBody] AulaDTO input)
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
        public override ActionResult<AulaDTO> Delete(Guid id)
        {
            _applicationServiceAula.DeleteById(id);
            return Ok("Removido");
        }
    }
}
