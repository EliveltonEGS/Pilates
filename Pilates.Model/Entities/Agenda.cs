using System;

namespace Pilates.Model.Entities
{
    public class Agenda : EntityBase
    {
        public DateTime DataAula { get; set; }
        public bool DiaDisponivel { get; set; }
        public int QuantidadeAulaPorSemana { get; set; }
        public Guid AulaId { get; set; }
        public Aula Aula { get; set; }
    }
}
