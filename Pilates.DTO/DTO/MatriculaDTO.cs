using System;

namespace Pilates.DTO.DTO
{
    public class MatriculaDTO : EntityBaseDTO
    {
        public Decimal ValorMatricula { get; set; }
        public DateTime DataVencimentoMatricula { get; set; }
        public Decimal ValorMensalidade { get; set; }
        public DateTime DataVencimentoMensalidade { get; set; }
        public Guid SalaId { get; set; }
        public SalaDTO SalaDTO { get; set; }
        public Guid FormaPagamentoId { get; set; }
        public FormaPagamentoDTO FormaPagamentoDTO { get; set; }
    }
}
