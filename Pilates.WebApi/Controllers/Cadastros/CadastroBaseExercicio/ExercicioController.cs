using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Exercicio;
using Pilates.DTO.DTO;
using System;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseExercicio
{
    [ApiController]
    [Route("[controller]")]
    public class ExercicioController : GenericController<ExercicioDTO>
    {

        private readonly IApplicationServiceExercicio _applicationServiceExercicio;

        public ExercicioController(IApplicationServiceExercicio applicationServiceExercicio)
        {
            _applicationServiceExercicio = applicationServiceExercicio;
        }

        [HttpGet]
        [Route("")]
        public override ActionResult<ExercicioDTO> GetAll()
        {
            return Ok(_applicationServiceExercicio.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public override ActionResult<ExercicioDTO> GetById(Guid id)
        {
            return Ok(_applicationServiceExercicio.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public override ActionResult<ExercicioDTO> Post([FromBody] ExercicioDTO input)
        {
            if (ModelState.IsValid)
            {
                _applicationServiceExercicio.Save(input);
                return input;
            }
            else
            {
                return BadRequest(input);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public override ActionResult<ExercicioDTO> Put(Guid id, [FromBody] ExercicioDTO input)
        {
            if (input == null || input.ExercicioId != id)
            {
                return BadRequest(input);
            }
            else
            {
                _applicationServiceExercicio.Update(input);
                return input;
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public override ActionResult<ExercicioDTO> Delete(Guid id)
        {
            _applicationServiceExercicio.DeleteById(id);
            return Ok("Removido");
        }
    }
}
