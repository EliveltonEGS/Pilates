using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAparelho
{
    public class MapperContasPagar : IMapperContasPagar
    {
        List<AparelhoDTO> aparelhoDTOs = new List<AparelhoDTO>();

        public async Task<IEnumerable<AparelhoDTO>> MapperListAparelhos(Task<IEnumerable<Aparelho>> aparelhos)
        {
            foreach(var item in await aparelhos)
            {
                AparelhoDTO aparelhoDTO = new AparelhoDTO()
                {
                    Id = item.Id,
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
                Id = aparelho.Id,
                Descricao = aparelho.Descricao
            };

            return aparelhoDTO;
        }

        public Aparelho MapperToEntity(AparelhoDTO aparelhoDTO)
        {
            Aparelho Aparelho = new Aparelho()
            {
                Id = aparelhoDTO.Id,
                Descricao = aparelhoDTO.Descricao
            };

            return Aparelho;
        }
    }
}
