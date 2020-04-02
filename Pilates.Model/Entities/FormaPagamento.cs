using System;

namespace Pilates.Model.Entities
{
    public class FormaPagamento
    {
        public FormaPagamento()
        {
            FormaPagamentoId = Guid.NewGuid();
        }

        public Guid FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
    }
}
