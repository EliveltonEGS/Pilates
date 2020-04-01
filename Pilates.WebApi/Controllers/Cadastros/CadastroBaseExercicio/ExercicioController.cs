using Microsoft.AspNetCore.Mvc;
using Pilates.Application.Services.Exercicio;
using Pilates.DTO.DTO;
using System;
using System.Threading.Tasks;

namespace Pilates.WebApi.Controllers.Cadastros.CadastroBaseExercicio
{
    [ApiController]
    [Route("[controller]")]
    public class ExercicioController : ControllerBase
    {

        private readonly IApplicationServiceExercicio _applicationServiceExercicio;

        public ExercicioController(IApplicationServiceExercicio applicationServiceExercicio)
        {
            _applicationServiceExercicio = applicationServiceExercicio;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<ExercicioDTO>> Get()
        {
            return Ok(await _applicationServiceExercicio.GetAll());
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult<ExercicioDTO> Get(Guid id)
        {
            return Ok(_applicationServiceExercicio.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ExercicioDTO> Post([FromBody] ExercicioDTO input)
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
        public ActionResult<ExercicioDTO> Put(Guid id, [FromBody] ExercicioDTO input)
        {
            if (input == null || input.Id != id)
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
        public ActionResult<ExercicioDTO> Delete(Guid id)
        {
            _applicationServiceExercicio.DeleteById(id);
            return Ok("Removido");
        }
    }
}
