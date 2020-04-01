using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseFormaPagamento
{
    public interface IMapperFormaPagamento
    { 
        FormaPagamento MapperToEntity(FormaPagamentoDTO formaPagamentoDTO);
        Task<IEnumerable<FormaPagamentoDTO>> MapperListFormaPagamentos(Task<IEnumerable<FormaPagamento>> formaPagamentos);
        FormaPagamentoDTO MapperToDTO(FormaPagamento formaPagamento);
    }
}
