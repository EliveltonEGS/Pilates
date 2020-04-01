using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.ContasPagar;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseContasPagar
{
    [ApiController]
    [Route("[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly IApplicationServiceContasPagar _applicationServiceContasPagar;

        public ContasPagarController(IApplicationServiceContasPagar applicationServiceContasPagar)
        {
            _applicationServiceContasPagar = applicationServiceContasPagar;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<ContasPagarDTO>> Get()
        {
            return Ok(await _applicationServiceContasPagar.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<ContasPagarDTO> Get(Guid id)
        {
            return Ok(_applicationServiceContasPagar.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ContasPagarDTO> Post([FromBody] ContasPagarDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceContasPagar.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<ContasPagarDTO> Put(Guid id, [FromBody] ContasPagarDTO input)
        {
            if (input == null || input.Id != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceContasPagar.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<ContasPagarDTO> Delete(Guid id)
        {
            _applicationServiceContasPagar.DeleteById(id);
            return Ok("Removido");
        }
    }
}
