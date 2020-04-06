using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Endereco;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseEndereco
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : GenericController<EnderecoDTO>
    {

        private readonly IApplicationServiceEndereco _applicationServiceEndereco;

        public EnderecoController(IApplicationServiceEndereco applicationServiceEndereco)
        {
            _applicationServiceEndereco = applicationServiceEndereco;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<EnderecoDTO> GetAll()
        {
            return Ok(_applicationServiceEndereco.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<EnderecoDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceEndereco.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<EnderecoDTO> Post([FromBody] EnderecoDTO input)
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
        public override ActionResult<EnderecoDTO> Put(Guid id, [FromBody] EnderecoDTO input)
        {
            if (input == null || input.EnderecoId != id)
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
        public override ActionResult<EnderecoDTO> Delete(Guid id)
        {
            _applicationServiceEndereco.DeleteById(id);
            return Ok("Removido");
        }
    }
}
