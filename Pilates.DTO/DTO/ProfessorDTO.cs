using System;

namespace Pilates.DTO.DTO
{
    public class ProfessorDTO : PessoaDTO
    {
        public ProfessorDTO()
        {
            ProfessorId = Guid.NewGuid();
        }

        public Guid ProfessorId { get; set; }
        public Guid EspecialidadeId { get; set; }
        public EspecialidadeDTO Especialidade { get; set; }
        public Guid EnderecoId { get; set; }
        public EnderecoDTO EnderecoDTO { get; set; }
    }
}
