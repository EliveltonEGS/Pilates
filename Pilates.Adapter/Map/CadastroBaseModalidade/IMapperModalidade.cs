using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;

namespace Pilates.Adapter.Map.CadastroBaseModalidade
{
    public interface IMapperModalidade
    {
        Modalidade MapperToEntity(ModalidadeDTO modalidadeDTO);
        IEnumerable<ModalidadeDTO> MapperListModalidades(IEnumerable<Modalidade> modalidades);
        ModalidadeDTO MapperToDTO(Modalidade modalidade);
    }
}
