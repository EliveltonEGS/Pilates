using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAula
{
    public interface IMapperAula
    {
        Aula MapperToEntity(AulaDTO aulaDTO);
        Task<IEnumerable<AulaDTO>> MapperListAulas(Task<IEnumerable<Aula>> aulas);
        AulaDTO MapperToDTO(Aula aula);
    }
}
