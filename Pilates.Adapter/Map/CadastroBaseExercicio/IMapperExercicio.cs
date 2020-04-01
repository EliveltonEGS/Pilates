using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseExercicio
{
    public interface IMapperExercicio
    { 
        Exercicio MapperToEntity(ExercicioDTO exercicioDTO);
        Task<IEnumerable<ExercicioDTO>> MapperListExercicios(Task<IEnumerable<Exercicio>> exercicios);
        ExercicioDTO MapperToDTO(Exercicio exercicio);
    }
}
