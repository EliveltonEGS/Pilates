using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseModalidade
{
    public interface IMapperModalidade
    {
        Modalidade MapperToEntity(ModalidadeDTO modalidadeDTO);
        Task<IEnumerable<ModalidadeDTO>> MapperListModalidades(Task<IEnumerable<Modalidade>> modalidades);
        ModalidadeDTO MapperToDTO(Modalidade modalidade);
    }
}
