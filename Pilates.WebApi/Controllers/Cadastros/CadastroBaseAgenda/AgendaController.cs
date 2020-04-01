using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Agenda;
using Pilates.DTO.DTO;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAgenda
{
    [Route("[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {

        private readonly IApplicationServiceAgenda _applicationServiceAgenda;

        public AgendaController(IApplicationServiceAgenda applicationServiceAgenda)
        {
            _applicationServiceAgenda = applicationServiceAgenda;
        }

        [HttpGet]
        public async Task<ActionResult<AgendaDTO>> Get()
        {
            return Ok(await _applicationServiceAgenda.GetAll());
        }

        [HttpGet("{id:Guid}")]
        public ActionResult<AgendaDTO> Get(Guid id)
        {
            return Ok(_applicationServiceAgenda.GetById(id));
        }

        [HttpPost]
        public ActionResult<AgendaDTO> Post([FromBody] AgendaDTO input)
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
        public ActionResult<AgendaDTO> Put(Guid id, [FromBody] AgendaDTO input)
        {
            if(input ==  null || input.Id != id) 
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
        public ActionResult<AgendaDTO> Delete(Guid id)
        {
            _applicationServiceAgenda.DeleteById(id);
            return Ok("Removido");
        }
    }
}
