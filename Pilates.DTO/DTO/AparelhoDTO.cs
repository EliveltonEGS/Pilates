using System;

namespace Pilates.DTO.DTO
{
    public class AparelhoDTO
    {
        public AparelhoDTO()
        {
            AparelhoId = Guid.NewGuid();
        }

        public Guid AparelhoId { get; set; }
        public string Descricao { get; set; }
    }
}
