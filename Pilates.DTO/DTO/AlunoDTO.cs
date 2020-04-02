using System;

namespace Pilates.DTO.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public AlunoDTO()
        {
            AlunoId = Guid.NewGuid();
        }

        public Guid AlunoId { get; set; }
        public string NomeResponsavel { get; set; }
        public string ComoConheceu { get; set; }
        public Guid EnderecoId { get; set; }
        public EnderecoDTO Endereco { get; set; }
    }
}
