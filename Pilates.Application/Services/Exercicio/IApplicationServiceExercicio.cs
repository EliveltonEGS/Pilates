using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Exercicio
{
    public interface IApplicationServiceExercicio
    {
        Task<IEnumerable<ExercicioDTO>> GetAll();
        void Update(ExercicioDTO input);
        void DeleteById(Guid id);
        ExercicioDTO GetById(Guid id);
        void Save(ExercicioDTO input);
    }
}
