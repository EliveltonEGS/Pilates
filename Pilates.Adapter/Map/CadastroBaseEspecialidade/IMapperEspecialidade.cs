using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseEspecialidade
{
    public interface IMapperEspecialidade
    { 
        Especialidade MapperToEntity(EspecialidadeDTO especialidadeDTO);
        Task<IEnumerable<EspecialidadeDTO>> MapperListEspecialidades(Task<IEnumerable<Especialidade>> especialidades);
        EspecialidadeDTO MapperToDTO(Especialidade especialidade);
    }
}
