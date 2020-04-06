using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.FormaPagamento;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseFormaPagamento
{
    [ApiController]
    [Route("[controller]")]
    public class FormaPagamentoController : GenericController<FormaPagamentoDTO>
    {
        private readonly IApplicationServiceFormaPagamento _applicationServiceFormaPagamento;

        public FormaPagamentoController(IApplicationServiceFormaPagamento applicationServiceFormaPagamento)
        {
            _applicationServiceFormaPagamento = applicationServiceFormaPagamento;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<FormaPagamentoDTO> GetAll()
        {
            return Ok(_applicationServiceFormaPagamento.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<FormaPagamentoDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceFormaPagamento.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<FormaPagamentoDTO> Post([FromBody] FormaPagamentoDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceFormaPagamento.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<FormaPagamentoDTO> Put(Guid id, [FromBody] FormaPagamentoDTO input)
        {
            if (input == null || input.FormaPagamentoId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceFormaPagamento.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<FormaPagamentoDTO> Delete(Guid id)
        {
            _applicationServiceFormaPagamento.DeleteById(id);
            return Ok("Removido");
        }
    }
}
