using System;

namespace Pilates.DTO.DTO
{
    public class EnderecoDTO
    {
        public EnderecoDTO()
        {
            EnderecoId = Guid.NewGuid();
        }

        public Guid EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Guid CidadeId { get; set; }
        public CidadeDTO CidadeDTO { get; set; }

    }
}
