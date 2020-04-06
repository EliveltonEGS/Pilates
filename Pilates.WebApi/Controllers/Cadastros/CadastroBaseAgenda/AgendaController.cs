using System;
using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Agenda;
using Pilates.DTO.DTO;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAgenda
{
    [Route("[controller]")]
    [ApiController]
    public class AgendaController : GenericController<AgendaDTO>
    {

        private readonly IApplicationServiceAgenda _applicationServiceAgenda;

        public AgendaController(IApplicationServiceAgenda applicationServiceAgenda)
        {
            _applicationServiceAgenda = applicationServiceAgenda;
        }

        [HttpGet]
        public override ActionResult<AgendaDTO> GetAll()
        {
            return Ok(_applicationServiceAgenda.GetAll());
        }

        [HttpGet("{id:Guid}")]
        public override ActionResult<AgendaDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceAgenda.GetById(id));
        }

        [HttpPost]
        public override ActionResult<AgendaDTO> Post([FromBody] AgendaDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceAgenda.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut("{id:Guid}")]
        public override ActionResult<AgendaDTO> Put(Guid id, [FromBody] AgendaDTO input)
        {
            if(input ==  null || input.AgendaId != id) 
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceAgenda.Update(input);
                return input;
            }
        }

        [HttpDelete("{id:Guid}")]
        public override ActionResult<AgendaDTO> Delete(Guid id)
        {
            _applicationServiceAgenda.DeleteById(id);
            return Ok("Removido");
        }
    }
}
