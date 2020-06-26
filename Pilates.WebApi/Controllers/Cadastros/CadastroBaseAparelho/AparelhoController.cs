using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Aparelho;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAparelho
{
    [ApiController]
    [Route("api/aparelhos")]
    public class AparelhoController : GenericController<AparelhoDTO>
    {

        private readonly IApplicationServiceAparelho _applicationServiceAparelho;

        public AparelhoController(IApplicationServiceAparelho applicationServiceAparelho)
        {
            _applicationServiceAparelho = applicationServiceAparelho;
        }

        [HttpDelete, Route("{id:Guid}")]
        public override ActionResult<AparelhoDTO> Delete(Guid id)
        {
            _applicationServiceAparelho.DeleteById(id);
            return Ok("Removido");
        }

        [HttpGet, Route("")]
        public override ActionResult<AparelhoDTO> GetAll()
        {
            return Ok(_applicationServiceAparelho.GetAll());
        }

        [HttpGet, Route("{id:Guid}")]
        public override ActionResult<AparelhoDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceAparelho.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<AparelhoDTO> Post([FromBody] AparelhoDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceAparelho.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut, Route("{id:Guid}")]
        public override ActionResult<AparelhoDTO> Put(Guid id, [FromBody] AparelhoDTO input)
        {
            if (input == null || input.AparelhoId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceAparelho.Update(input);
                return input;
            }
        }
    }
}
