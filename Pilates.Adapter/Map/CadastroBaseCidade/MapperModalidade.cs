using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseCidade
{
    public class MapperCidade : IMapperCidade
    {

        List<CidadeDTO> cidadeDTOs = new List<CidadeDTO>();


        public async Task<IEnumerable<CidadeDTO>> MapperListCidades(Task<IEnumerable<Cidade>> cidades)
        {
            foreach (var item in await cidades)
            {
                CidadeDTO cidadeDTO = new CidadeDTO()
                {
                    CidadeId = item.CidadeId,
                    Descricao = item.Descricao,
                    Cep = item.Cep,
                    Estado = item.Estado
                };

                cidadeDTOs.Add(cidadeDTO);
            }

            return cidadeDTOs;
        }

        public CidadeDTO MapperToDTO(Cidade cidade)
        {
            CidadeDTO cidadeDTO = new CidadeDTO()
            {
                CidadeId = cidade.CidadeId,
                Descricao = cidade.Descricao,
                Estado = cidade.Estado,
                Cep = cidade.Cep
            };

            return cidadeDTO;
        }

        public Cidade MapperToEntity(CidadeDTO cidadeDTO)
        {
            Cidade cidade = new Cidade()
            {
                CidadeId = cidadeDTO.CidadeId,
                Descricao = cidadeDTO.Descricao,
                Estado = cidadeDTO.Estado,
                Cep = cidadeDTO.Cep
            };

            return cidade;
        }
    }
}
