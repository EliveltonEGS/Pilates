using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Professor;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseProfessor
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : GenericController<ProfessorDTO>
    {

        private readonly IApplicationServiceProfessor _applicationServiceProfessor;

        public ProfessorController(IApplicationServiceProfessor applicationServiceProfessor)
        {
            _applicationServiceProfessor = applicationServiceProfessor;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<ProfessorDTO> GetAll()
        {
            return Ok(_applicationServiceProfessor.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<ProfessorDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceProfessor.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<ProfessorDTO> Post([FromBody] ProfessorDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceProfessor.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<ProfessorDTO> Put(Guid id, [FromBody] ProfessorDTO input)
        {
            if (input == null || input.ProfessorId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceProfessor.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<ProfessorDTO> Delete(Guid id)
        {
            _applicationServiceProfessor.DeleteById(id);
            return Ok("Removido");
        }
    }
}
