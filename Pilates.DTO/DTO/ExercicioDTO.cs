using System;

namespace Pilates.DTO.DTO
{
    public class ExercicioDTO : EntityBaseDTO
    {
        public string Descricao { get; set; }
        public Guid AparelhoId { get; set; }
        public AparelhoDTO AparelhoDTO { get; set; }
    }
}
