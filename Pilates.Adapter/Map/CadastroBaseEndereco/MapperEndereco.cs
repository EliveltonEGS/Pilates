using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseEndereco
{
    public class MapperEndereco : IMapperEndereco
    {

        List<EnderecoDTO> enderecoDTOs = new List<EnderecoDTO>();

        public async Task<IEnumerable<EnderecoDTO>> MapperListEnderecos(Task<IEnumerable<Endereco>> enderecos)
        {
            foreach (var item in await enderecos)
            {
                EnderecoDTO enderecoDTO = new EnderecoDTO()
                {
                    Id = item.Id,
                    Bairro = item.Bairro,
                    CidadeId = item.CidadeId,
                    Complemento = item.Complemento,
                    Logradouro = item.Logradouro,
                    Numero = item.Numero
                };

                enderecoDTOs.Add(enderecoDTO);
            }

            return enderecoDTOs;
        }

        public EnderecoDTO MapperToDTO(Endereco endereco)
        {
            EnderecoDTO enderecoDTO = new EnderecoDTO()
            {
                Id = endereco.Id,
                Bairro = endereco.Bairro,
                CidadeId = endereco.CidadeId,
                Complemento = endereco.Complemento,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero
            };

            return enderecoDTO;
        }

        public Endereco MapperToEntity(EnderecoDTO enderecoDTO)
        {
            Endereco endereco = new Endereco()
            {
                Id = enderecoDTO.Id,
                Bairro = enderecoDTO.Bairro,
                CidadeId = enderecoDTO.CidadeId,
                Complemento = enderecoDTO.Complemento,
                Logradouro = enderecoDTO.Logradouro,
                Numero = enderecoDTO.Numero
            };

            return endereco;
        }
    }
}
