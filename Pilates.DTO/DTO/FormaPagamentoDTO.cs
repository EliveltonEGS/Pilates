using System;

namespace Pilates.DTO.DTO
{
    public class FormaPagamentoDTO
    {
        public FormaPagamentoDTO()
        {
            FormaPagamentoId = Guid.NewGuid();
        }

        public Guid FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
    }
}
