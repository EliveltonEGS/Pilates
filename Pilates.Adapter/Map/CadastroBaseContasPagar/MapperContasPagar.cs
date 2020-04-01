using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseContasPagar
{
    public class MapperContasPagar : IMapperContasPagar
    {
        List<ContasPagarDTO> contasPagarDTOs = new List<ContasPagarDTO>();

        public async Task<IEnumerable<ContasPagarDTO>> MapperListContasPagar(Task<IEnumerable<ContasPagar>> contasPagars)
        {
            foreach(var item in await contasPagars)
            {
                ContasPagarDTO contasPagarDTO = new ContasPagarDTO()
                {
                    Id = item.Id,
                    Liberado = item.Liberado,
                    StatusPagamento = item.StatusPagamento,
                    MatriculaId = item.MatriculaId
                };

                contasPagarDTOs.Add(contasPagarDTO);
            }

            return contasPagarDTOs;
        }

        public ContasPagarDTO MapperToDTO(ContasPagar contasPagar)
        {
            ContasPagarDTO contasPagarDTO = new ContasPagarDTO()
            {
                Id = contasPagar.Id,
                Liberado = contasPagar.Liberado,
                StatusPagamento = contasPagar.StatusPagamento,
                MatriculaId = contasPagar.MatriculaId
            };

            return contasPagarDTO;
        }

        public ContasPagar MapperToEntity(ContasPagarDTO contasPagarDTO)
        {
            ContasPagar contasPagar = new ContasPagar()
            {
                Id = contasPagarDTO.Id,
                Liberado = contasPagarDTO.Liberado,
                StatusPagamento = contasPagarDTO.StatusPagamento,
                MatriculaId = contasPagarDTO.MatriculaId
            };

            return contasPagar;
        }
    }
}
