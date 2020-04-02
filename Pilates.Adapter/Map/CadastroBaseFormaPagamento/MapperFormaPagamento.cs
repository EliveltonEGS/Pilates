using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseFormaPagamento
{
    public class MapperFormaPagamento : IMapperFormaPagamento
    {

        List<FormaPagamentoDTO> formaPagamentoDTOs = new List<FormaPagamentoDTO>();

        public async Task<IEnumerable<FormaPagamentoDTO>> MapperListFormaPagamentos(Task<IEnumerable<FormaPagamento>> formaPagamentos)
        {
            foreach (var item in await formaPagamentos)
            {
                FormaPagamentoDTO formaPagamentoDTO = new FormaPagamentoDTO()
                {
                    FormaPagamentoId = item.FormaPagamentoId,
                    Descricao = item.Descricao
                };

                formaPagamentoDTOs.Add(formaPagamentoDTO);
            }

            return formaPagamentoDTOs;
        }

        public FormaPagamentoDTO MapperToDTO(FormaPagamento formaPagamento)
        {
            FormaPagamentoDTO formaPagamentoDTO = new FormaPagamentoDTO()
            {
                FormaPagamentoId = formaPagamento.FormaPagamentoId,
                Descricao = formaPagamento.Descricao
            };

            return formaPagamentoDTO;
        }

        public FormaPagamento MapperToEntity(FormaPagamentoDTO formaPagamentoDTO)
        {
            FormaPagamento formaPagamento = new FormaPagamento()
            {
                FormaPagamentoId = formaPagamentoDTO.FormaPagamentoId,
                Descricao = formaPagamentoDTO.Descricao
            };

            return formaPagamento;
        }
    }
}
