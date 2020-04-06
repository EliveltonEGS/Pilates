using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Sala;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseSala
{
    [ApiController]
    [Route("[controller]")]
    public class SalaController : GenericController<SalaDTO>
    {
        private readonly IApplicationServiceSala _applicationServiceSala;

        public SalaController(IApplicationServiceSala applicationServiceSala)
        {
            _applicationServiceSala = applicationServiceSala;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<SalaDTO> GetAll()
        {
            return Ok(_applicationServiceSala.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<SalaDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceSala.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<SalaDTO> Post([FromBody] SalaDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceSala.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<SalaDTO> Put(Guid id, [FromBody] SalaDTO input)
        {
            if (input == null || input.SalaId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceSala.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<SalaDTO> Delete(Guid id)
        {
            _applicationServiceSala.DeleteById(id);
            return Ok("Removido");
        }
    }
}
