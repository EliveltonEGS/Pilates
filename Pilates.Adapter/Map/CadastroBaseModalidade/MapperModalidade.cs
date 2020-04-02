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
                    ModalidadeId = item.ModalidadeId,
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
                ModalidadeId = modalidade.ModalidadeId,
                Descricao = modalidade.Descricao
            };

            return modalidadeDTO;
        }

        public Modalidade MapperToEntity(ModalidadeDTO modalidadeDTO)
        {
            Modalidade modalidade = new Modalidade()
            {
                ModalidadeId = modalidadeDTO.ModalidadeId,
                Descricao = modalidadeDTO.Descricao
            };

            return modalidade;
        }
    }
}
