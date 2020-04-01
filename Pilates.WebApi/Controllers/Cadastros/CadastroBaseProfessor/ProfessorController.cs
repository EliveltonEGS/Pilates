using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Professor;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseProfessor
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {

        private readonly IApplicationServiceProfessor _applicationServiceProfessor;

        public ProfessorController(IApplicationServiceProfessor applicationServiceProfessor)
        {
            _applicationServiceProfessor = applicationServiceProfessor;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<ProfessorDTO>> Get()
        {
            return Ok(await _applicationServiceProfessor.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<ProfessorDTO> Get(Guid id)
        {
            return Ok(_applicationServiceProfessor.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ProfessorDTO> Post([FromBody] ProfessorDTO input)
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
        public ActionResult<ProfessorDTO> Put(Guid id, [FromBody] ProfessorDTO input)
        {
            if (input == null || input.Id != id)
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
        public ActionResult<ProfessorDTO> Delete(Guid id)
        {
            _applicationServiceProfessor.DeleteById(id);
            return Ok("Removido");
        }
    }
}
