using System;

namespace Pilates.DTO.DTO
{
    public class CidadeDTO
    {
        public CidadeDTO()
        {
            CidadeId = Guid.NewGuid();
        }

        public Guid CidadeId { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
