using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pilates.Application.Services.Aparelho;
using Pilates.Dapper.Repositories;
using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAparelho
{
    [ApiController]
    [Route("[controller]")]
    public class AparelhoController : ControllerBase
    {

        private readonly IApplicationServiceAparelho _applicationServiceAparelho;

        public AparelhoController(IApplicationServiceAparelho applicationServiceAparelho)
        {
            _applicationServiceAparelho = applicationServiceAparelho;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<AparelhoDTO> Get()
        {
            return Ok(_applicationServiceAparelho.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<AparelhoDTO> Get(Guid id)
        {
            return Ok(_applicationServiceAparelho.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<AparelhoDTO> Post([FromBody] AparelhoDTO input)
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

        [HttpPut]
        [Route("{id:Guid}")]
        public ActionResult<AparelhoDTO> Put(Guid id, [FromBody] AparelhoDTO input)
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

        [HttpDelete]
        [Route("{id:Guid}")]
        public ActionResult<AparelhoDTO> Delete(Guid id)
        {
            _applicationServiceAparelho.DeleteById(id);
            return Ok("Removido");
        }
    }
}
