using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAparelho
{
    public class MapperAparelho : IMapperAparelho
    {
        List<AparelhoDTO> aparelhoDTOs = new List<AparelhoDTO>();

        public async Task<IEnumerable<AparelhoDTO>> MapperListAparelhos(Task<IEnumerable<Aparelho>> aparelhos)
        {
            foreach(var item in await aparelhos)
            {
                AparelhoDTO aparelhoDTO = new AparelhoDTO()
                {
                    AparelhoId = item.AparelhoId,
                    Descricao = item.Descricao
                };

                aparelhoDTOs.Add(aparelhoDTO);
            }

            return aparelhoDTOs;
        }

        public AparelhoDTO MapperToDTO(Aparelho aparelho)
        {
            AparelhoDTO aparelhoDTO = new AparelhoDTO()
            {
                AparelhoId = aparelho.AparelhoId,
                Descricao = aparelho.Descricao
            };

            return aparelhoDTO;
        }

        public Aparelho MapperToEntity(AparelhoDTO aparelhoDTO)
        {
            Aparelho Aparelho = new Aparelho()
            {
                AparelhoId = aparelhoDTO.AparelhoId,
                Descricao = aparelhoDTO.Descricao
            };

            return Aparelho;
        }
    }
}
