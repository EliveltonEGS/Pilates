using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAparelho
{
    public interface IMapperContasPagar
    {
        Aparelho MapperToEntity(AparelhoDTO aparelhoDTO);
        Task<IEnumerable<AparelhoDTO>> MapperListAparelhos(Task<IEnumerable<Aparelho>> aparelhos);
        AparelhoDTO MapperToDTO(Aparelho aparelho);
    }
}
