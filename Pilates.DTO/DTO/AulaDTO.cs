using System;

namespace Pilates.DTO.DTO
{
    public class AulaDTO
    {
        public AulaDTO()
        {
            AulaId = Guid.NewGuid();
        }

        public Guid AulaId { get; set; }
        public string Descricao { get; set; }
        public Guid ExercicioId { get; set; }
        public ExercicioDTO Exercicio { get; set; }
        public Guid ModalidadeId { get; set; }
        public ModalidadeDTO ModalidadeDTO { get; set; }
        public Guid ProfessorId { get; set; }
        public ProfessorDTO Professor { get; set; }
    }
}
