using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseExercicio
{ 
    public class MapperExercicio : IMapperExercicio
    { 

        List<ExercicioDTO> exercicioDTOs = new List<ExercicioDTO>();

        public async Task<IEnumerable<ExercicioDTO>> MapperListExercicios(Task<IEnumerable<Exercicio>> exercicios)
        {
            foreach (var item in await exercicios)
            {
                ExercicioDTO exercicioDTO = new ExercicioDTO()
                {
                    ExercicioId = item.ExercicioId,
                   Descricao = item.Descricao,
                   AparelhoId = item.AparelhoId
                };

                exercicioDTOs.Add(exercicioDTO);
            }

            return exercicioDTOs;
        }

        public ExercicioDTO MapperToDTO(Exercicio exercicio)
        {
            ExercicioDTO exercicioDTO = new ExercicioDTO()
            {
                ExercicioId = exercicio.ExercicioId,
                Descricao = exercicio.Descricao,
                AparelhoId = exercicio.AparelhoId
            };

            return exercicioDTO;
        }

        public Exercicio MapperToEntity(ExercicioDTO exercicioDTO)
        {
            Exercicio exercicio = new Exercicio()
            {
                ExercicioId = exercicioDTO.ExercicioId,
                Descricao = exercicioDTO.Descricao,
                AparelhoId = exercicioDTO.AparelhoId
            };

            return exercicio;
        }
    }
}
