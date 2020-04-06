using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Matricula;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseMatricula
{
    [ApiController]
    [Route("[controller]")]
    public class MatriculaController : GenericController<MatriculaDTO>
    {

        private readonly IApplicationServiceMatricula _applicationServiceMatricula;

        public MatriculaController(IApplicationServiceMatricula applicationServiceMatricula)
        {
            _applicationServiceMatricula = applicationServiceMatricula;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<MatriculaDTO> GetAll()
        {
            return Ok(_applicationServiceMatricula.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<MatriculaDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceMatricula.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<MatriculaDTO> Post([FromBody] MatriculaDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceMatricula.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<MatriculaDTO> Put(Guid id, [FromBody] MatriculaDTO input)
        {
            if (input == null || input.MatriculaId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceMatricula.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<MatriculaDTO> Delete(Guid id)
        {
            _applicationServiceMatricula.DeleteById(id);
            return Ok("Removido");
        }
    }
}
