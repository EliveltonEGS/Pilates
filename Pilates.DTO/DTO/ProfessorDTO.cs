using System;

namespace Pilates.DTO.DTO
{
    public class ProfessorDTO : PessoaDTO
    {
        public Guid EspecialidadeId { get; set; }
        public EspecialidadeDTO Especialidade { get; set; }
        public Guid EnderecoId { get; set; }
        public EnderecoDTO EnderecoDTO { get; set; }
    }
}
