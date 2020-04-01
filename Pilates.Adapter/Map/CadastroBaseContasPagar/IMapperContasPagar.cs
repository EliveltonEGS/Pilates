using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseContasPagar 
{
    public interface IMapperContasPagar
    {
    
        ContasPagar MapperToEntity(ContasPagarDTO contasPagarDTO);
        Task<IEnumerable<ContasPagarDTO>> MapperListContasPagar(Task<IEnumerable<ContasPagar>> contasPagars);
        ContasPagarDTO MapperToDTO(ContasPagar contasPagar);
    }
}
