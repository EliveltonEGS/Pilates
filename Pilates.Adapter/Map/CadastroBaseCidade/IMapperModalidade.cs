using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseCidade
{
    public interface IMapperCidade
    {
        Cidade MapperToEntity(CidadeDTO cidadeDTO);
        Task<IEnumerable<CidadeDTO>> MapperListCidades(Task<IEnumerable<Cidade>> cidades);
        CidadeDTO MapperToDTO(Cidade cidade);
    }
}
