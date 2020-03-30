using System;

namespace Pilates.DTO.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public string NomeResponsavel { get; set; }
        public string ComoConheceu { get; set; }
        public Guid EnderecoId { get; set; }
        public EnderecoDTO Endereco { get; set; }
    }
}
