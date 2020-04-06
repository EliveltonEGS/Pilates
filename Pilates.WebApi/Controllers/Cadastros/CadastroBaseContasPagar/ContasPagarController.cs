using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.ContasPagar;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseContasPagar
{
    [ApiController]
    [Route("[controller]")]
    public class ContasPagarController : GenericController<ContasPagarDTO>
    {
        private readonly IApplicationServiceContasPagar _applicationServiceContasPagar;

        public ContasPagarController(IApplicationServiceContasPagar applicationServiceContasPagar)
        {
            _applicationServiceContasPagar = applicationServiceContasPagar;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<ContasPagarDTO> GetAll()
        {
            return Ok(_applicationServiceContasPagar.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<ContasPagarDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceContasPagar.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<ContasPagarDTO> Post([FromBody] ContasPagarDTO input)
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
        public override ActionResult<ContasPagarDTO> Put(Guid id, [FromBody] ContasPagarDTO input)
        {
            if (input == null || input.ContasPagarId != id)
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
        public override ActionResult<ContasPagarDTO> Delete(Guid id)
        {
            _applicationServiceContasPagar.DeleteById(id);
            return Ok("Removido");
        }
    }
}
