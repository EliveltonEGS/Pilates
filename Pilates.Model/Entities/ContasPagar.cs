using System;

namespace Pilates.Model.Entities
{
    public class ContasPagar
    {
        public ContasPagar()
        {
            ContasPagarId = Guid.NewGuid();
        }

        public Guid ContasPagarId { get; set; }
        public string StatusPagamento { get; set; }
        public string Liberado { get; set; }
        public Guid MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
    }
}
