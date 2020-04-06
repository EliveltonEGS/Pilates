using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Cidade;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseCidade
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : GenericController<CidadeDTO>
    {

        private readonly IApplicationServiceCidade _applicationServiceCidade;

        public CidadeController(IApplicationServiceCidade applicationServiceCidade)
        {
            _applicationServiceCidade = applicationServiceCidade;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<CidadeDTO> GetAll()
        {
            return Ok(_applicationServiceCidade.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<CidadeDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceCidade.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<CidadeDTO> Post([FromBody] CidadeDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceCidade.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<CidadeDTO> Put(Guid id, [FromBody] CidadeDTO input)
        {
            if (input == null || input.CidadeId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceCidade.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<CidadeDTO> Delete(Guid id)
        {
            _applicationServiceCidade.DeleteById(id);
            return Ok("Removido");
        }
    }
}
