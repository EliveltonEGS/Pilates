using System;

namespace Pilates.DTO.DTO
{
    public class SalaDTO
    {
        public SalaDTO()
        {
            SalaId = Guid.NewGuid();
        }

        public Guid SalaId { get; set; }
        public string Descricao { get; set; }
    }
}
