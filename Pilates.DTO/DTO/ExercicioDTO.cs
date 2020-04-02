using System;

namespace Pilates.DTO.DTO
{
    public class ExercicioDTO
    {
        public ExercicioDTO()
        {
            ExercicioId = Guid.NewGuid();
        }

        public Guid ExercicioId { get; set; }
        public string Descricao { get; set; }
        public Guid AparelhoId { get; set; }
        public AparelhoDTO AparelhoDTO { get; set; }
    }
}
