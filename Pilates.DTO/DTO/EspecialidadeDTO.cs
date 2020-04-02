using System;

namespace Pilates.DTO.DTO
{
    public class EspecialidadeDTO
    {
        public EspecialidadeDTO()
        {
            EspecialidadeId = Guid.NewGuid();
        }

        public Guid EspecialidadeId { get; set; }
        public string Descricao { get; set; }
    }
}
