using Pilates.Adapter.Map.CadastroBaseExercicio;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseExercicio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Exercicio
{
    public class ApplicationServiceExercicio : IApplicationServiceExercicio
    {

        private readonly IServiceExercicio _serviceExercicio;
        private readonly IMapperExercicio _mapperExercicio;

        public ApplicationServiceExercicio(
            IServiceExercicio serviceExercicio,
            IMapperExercicio mapperExercicio)
        {
            _serviceExercicio = serviceExercicio;
            _mapperExercicio = mapperExercicio;
        }

        public void DeleteById(Guid id)
        {
            _serviceExercicio.DeleteById(id);
        }

        public async Task<IEnumerable<ExercicioDTO>> GetAll()
        {
            return await _mapperExercicio.MapperListExercicios(_serviceExercicio.GetAll());
        }

        public ExercicioDTO GetById(Guid id)
        {
            return _mapperExercicio.MapperToDTO(_serviceExercicio.GetById(id));
        }

        public void Save(ExercicioDTO input)
        {
            _serviceExercicio.Save(_mapperExercicio.MapperToEntity(input));
        }

        public void Update(ExercicioDTO input)
        {
            _serviceExercicio.Update(_mapperExercicio.MapperToEntity(input));
        }
    }
}
