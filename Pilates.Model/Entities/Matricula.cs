using System;

namespace Pilates.Model.Entities
{
    public class Matricula
    {
        public Matricula()
        {
            MatriculaId = Guid.NewGuid();
        }

        public Guid MatriculaId { get; set; }
        public Decimal ValorMatricula { get; set; }
        public DateTime DataVencimentoMatricula { get; set; }
        public Decimal ValorMensalidade { get; set; }
        public DateTime DataVencimentoMensalidade { get; set; }
        public Guid SalaId { get; set; }
        public Sala Sala { get; set; }
        public Guid FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public Guid AulaId { get; set; }
        public Aula Aula { get; set; }
    }
}
