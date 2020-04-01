using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAula
{
    public class MapperAula : IMapperAula
    {

        List<AulaDTO> aulaDTOs = new List<AulaDTO>();

        public async Task<IEnumerable<AulaDTO>> MapperListAulas(Task<IEnumerable<Aula>> aulas)
        {
            foreach (var item in await aulas)
            {
                AulaDTO aulaDTO = new AulaDTO()
                {
                    Id = item.Id,
                    ExercicioId = item.ExercicioId,
                    ModalidadeId = item.ModalidadeId,
                    ProfessorId = item.ProfessorId
                };

                aulaDTOs.Add(aulaDTO);
            }

            return aulaDTOs;
        }

        public AulaDTO MapperToDTO(Aula aula)
        {
            AulaDTO aulaDTO = new AulaDTO()
            {
                Id = aula.Id,
                ExercicioId = aula.ExercicioId,
                ModalidadeId = aula.ModalidadeId,
                ProfessorId = aula.ProfessorId
            };

            return aulaDTO;
        }

        public Aula MapperToEntity(AulaDTO aulaDTO)
        {
            Aula aula = new Aula()
            {
                Id = aulaDTO.Id,
                ExercicioId = aulaDTO.ExercicioId,
                ModalidadeId = aulaDTO.ModalidadeId,
                ProfessorId = aulaDTO.ProfessorId
            };

            return aula;
        }
    }
}
