using System;

namespace Pilates.Model.Entities
{
    public class Aula : EntityBase
    {
        public Guid ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }
        public Guid ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
