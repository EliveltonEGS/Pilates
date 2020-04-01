using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseEndereco
{
    public interface IMapperEndereco
    {
        Endereco MapperToEntity(EnderecoDTO enderecoDTO);
        Task<IEnumerable<EnderecoDTO>> MapperListEnderecos(Task<IEnumerable<Endereco>> enderecos);
        EnderecoDTO MapperToDTO(Endereco endereco);
    }
}
