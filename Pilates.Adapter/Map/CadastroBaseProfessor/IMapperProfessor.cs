using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseProfessor
{
    public interface IMapperProfessor
    { 
        Professor MapperToEntity(ProfessorDTO professorDTO);
        Task<IEnumerable<ProfessorDTO>> MapperListProfessor(Task<IEnumerable<Professor>> professor);
        ProfessorDTO MapperToDTO(Professor professor);
    }
}
