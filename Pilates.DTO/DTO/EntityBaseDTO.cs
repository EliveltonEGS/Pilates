using System;

namespace Pilates.DTO.DTO
{
    public class EntityBaseDTO
    {

        public EntityBaseDTO()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
