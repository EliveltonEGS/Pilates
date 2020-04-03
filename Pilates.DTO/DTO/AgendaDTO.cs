using System;

namespace Pilates.DTO.DTO
{
    public class AgendaDTO
    {
        public AgendaDTO()
        {
            AgendaId = Guid.NewGuid();
        }

        public Guid AgendaId { get; set; }
        public DateTime DataAula { get; set; }
        public string DiaDisponivel { get; set; }
        public Guid AulaId { get; set; }
        public AulaDTO Aula { get; set; }
        public Guid ProessorId { get; set; }
        public ProfessorDTO Professor { get; set; }
    }
}
