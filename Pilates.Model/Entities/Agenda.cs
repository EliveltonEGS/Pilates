using System;

namespace Pilates.Model.Entities
{
    public class Agenda
    {
        public Agenda()
        {
            AngendaId = Guid.NewGuid();
        }

        public Guid AngendaId { get; set; }
        public DateTime DataAula { get; set; }
        public bool DiaDisponivel { get; set; }
        public Guid AulaId { get; set; }
        public Aula Aula { get; set; }
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
