using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Modalidade;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseModalidade
{
    [ApiController]
    [Route("[controller]")]
    public class ModalidadeController : ControllerBase
    {

        private readonly IApplicationServiceModalidade _applicationServiceModalidade;

        public ModalidadeController(IApplicationServiceModalidade applicationServiceModalidade)
        {
            _applicationServiceModalidade = applicationServiceModalidade;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<ModalidadeDTO>> Get()
        {
            return Ok(await _applicationServiceModalidade.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<ModalidadeDTO> Get(Guid id)
        {
            return Ok(_applicationServiceModalidade.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ModalidadeDTO> Post([FromBody] ModalidadeDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceModalidade.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<ModalidadeDTO> Put(Guid id, [FromBody] ModalidadeDTO input)
        {
            if (input == null || input.Id != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceModalidade.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<ModalidadeDTO> Delete(Guid id)
        {
            _applicationServiceModalidade.DeleteById(id);
            return Ok("Removido");
        }
    }
}
