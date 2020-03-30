using System;

namespace Pilates.Model.Entities
{
    public class ContasPagar : EntityBase
    {
        public string StatusPagamento { get; set; }
        public bool Liberado { get; set; }
        public Guid MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
    }
}
