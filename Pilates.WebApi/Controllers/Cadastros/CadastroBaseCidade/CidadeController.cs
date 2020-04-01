using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Cidade;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseCidade
{
    [ApiController]
    [Route("")]
    public class CidadeController : ControllerBase
    {

        private readonly IApplicationServiceCidade _applicationServiceCidade;

        public CidadeController(IApplicationServiceCidade applicationServiceCidade)
        {
            _applicationServiceCidade = applicationServiceCidade;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<CidadeDTO>> Get()
        {
            return Ok(await _applicationServiceCidade.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<CidadeDTO> Get(Guid id)
        {
            return Ok(_applicationServiceCidade.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<CidadeDTO> Post([FromBody] CidadeDTO input)
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
        public ActionResult<CidadeDTO> Put(Guid id, [FromBody] CidadeDTO input)
        {
            if (input == null || input.Id != id)
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
        public ActionResult<CidadeDTO> Delete(Guid id)
        {
            _applicationServiceCidade.DeleteById(id);
            return Ok("Removido");
        }
    }
}
