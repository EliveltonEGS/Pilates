using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAluno
{
    public interface IMapperAluno
    {
        Aluno MapperToEntity(AlunoDTO alunoDTO);
        Task<IEnumerable<AlunoDTO>> MapperListAlunos(Task<IEnumerable<Aluno>> alunos);
        AlunoDTO MapperToDTO(Aluno aluno);
    }
}
