using System;

namespace Pilates.DTO.DTO
{
    public class ModalidadeDTO
    {
        public ModalidadeDTO()
        {
            ModalidadeId = Guid.NewGuid();
        }

        public Guid ModalidadeId { get; set; }
        public string Descricao { get; set; }
    }
}
