using System;

namespace Pilates.DTO.DTO
{
    public class AgendaDTO : EntityBaseDTO
    {
        public DateTime DataAula { get; set; }
        public bool DiaDisponivel { get; set; }
        public int QuantidadeAulaPorSemana { get; set; }
        public Guid AulaId { get; set; }
        public AulaDTO Aula { get; set; }
    }
}
