using System;

namespace Pilates.Model.Entities
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            AlunoId = Guid.NewGuid();
        }

        public Guid AlunoId { get; set; }
        public string NomeResponsavel { get; set; }
        public string ComoConheceu { get; set; }
        public Guid EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
