using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseModalidade
{
    public class MapperModalidade : IMapperModalidade
    {

        List<ModalidadeDTO> modalidadeDTOs = new List<ModalidadeDTO>();


        public async Task<IEnumerable<ModalidadeDTO>> MapperListModalidades(Task<IEnumerable<Modalidade>> modalidades)
        {
            foreach (var item in await modalidades)
            {
                ModalidadeDTO modalidadeDTO = new ModalidadeDTO()
                {
                    Id = item.Id,
                    Descricao = item.Descricao
                };

                modalidadeDTOs.Add(modalidadeDTO);
            }

            return modalidadeDTOs;
        }

        public ModalidadeDTO MapperToDTO(Modalidade modalidade)
        {
            ModalidadeDTO modalidadeDTO = new ModalidadeDTO()
            {
                Id = modalidade.Id,
                Descricao = modalidade.Descricao
            };

            return modalidadeDTO;
        }

        public Modalidade MapperToEntity(ModalidadeDTO modalidadeDTO)
        {
            Modalidade modalidade = new Modalidade()
            {
                Id = modalidadeDTO.Id,
                Descricao = modalidadeDTO.Descricao
            };

            return modalidade;
        }
    }
}
