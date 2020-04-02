using System;

namespace Pilates.Model.Entities
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            ProfessorId = Guid.NewGuid();
        }

        public Guid ProfessorId { get; set; }
        public Guid EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
        public Guid EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
