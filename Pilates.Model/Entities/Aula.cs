using System;

namespace Pilates.Model.Entities
{
    public class Aula
    {
        public Aula()
        {
            AulaId = Guid.NewGuid();
        }

        public Guid AulaId { get; set; }
        public string Descricao { get; set; }
        public Guid ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }
        public Guid ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
