using System;

namespace Pilates.Model.Entities
{
    public class Endereco : EntityBase
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Guid CidadeId { get; set; }
        public Cidade Cidade { get; set; }

    }
}
