using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseMatricula
{
    public interface IMapperMatricula
    { 
        Matricula MapperToEntity(MatriculaDTO matriculaDTO);
        Task<IEnumerable<MatriculaDTO>> MapperListMatriculas(Task<IEnumerable<Matricula>> matriculas);
        MatriculaDTO MapperToDTO(Matricula matricula);
    }
}
