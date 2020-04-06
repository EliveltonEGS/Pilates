using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Aluno;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseAluno
{
    [Route("[controller]")]
    [ApiController]
    public class AlunoController : GenericController<AlunoDTO>
    {
        private readonly IApplicationServiceAluno _applicationServiceAluno;

        public AlunoController(IApplicationServiceAluno applicationServiceAluno)
        {
            _applicationServiceAluno = applicationServiceAluno;
        }

        [HttpGet, Route("")]
        public override ActionResult<AlunoDTO> GetAll()
        {
            var ret = _applicationServiceAluno.GetAll();
            return Ok(ret);
        }

        [HttpGet, Route("{id:Guid}")]
        public override ActionResult<AlunoDTO> GetById(Guid id)
        {
            var ret = _applicationServiceAluno.GetById(id);
            return Ok(ret);
        }

        [HttpPost]
        public override ActionResult<AlunoDTO> Post([FromBody] AlunoDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceAluno.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut, Route("{id:Guid}")]
        public override ActionResult<AlunoDTO> Put(Guid id, [FromBody] AlunoDTO input)
        {
            if (input == null || input.EnderecoId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceAluno.Update(input);
                return input;
            }
        }

        [HttpDelete, Route("{id:Guid}")]
        public override ActionResult<AlunoDTO> Delete(Guid id)
        {
            _applicationServiceAluno.DeleteById(id);
            return Ok("Removido");
        }
    }
}