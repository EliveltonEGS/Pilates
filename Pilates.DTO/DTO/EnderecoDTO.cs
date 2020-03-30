using System;

namespace Pilates.DTO.DTO
{
    public class EnderecoDTO : EntityBaseDTO
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Guid CidadeId { get; set; }
        public CidadeDTO CidadeDTO { get; set; }

    }
}
