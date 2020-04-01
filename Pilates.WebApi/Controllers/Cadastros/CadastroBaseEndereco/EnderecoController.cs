using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Endereco;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseEndereco
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {

        private readonly IApplicationServiceEndereco _applicationServiceEndereco;

        public EnderecoController(IApplicationServiceEndereco applicationServiceEndereco)
        {
            _applicationServiceEndereco = applicationServiceEndereco;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<EnderecoDTO>> Get()
        {
            return Ok(await _applicationServiceEndereco.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<EnderecoDTO> Get(Guid id)
        {
            return Ok(_applicationServiceEndereco.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<EnderecoDTO> Post([FromBody] EnderecoDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceEndereco.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<EnderecoDTO> Put(Guid id, [FromBody] EnderecoDTO input)
        {
            if (input == null || input.Id != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceEndereco.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<EnderecoDTO> Delete(Guid id)
        {
            _applicationServiceEndereco.DeleteById(id);
            return Ok("Removido");
        }
    }
}
