using System;

namespace Pilates.Model.Entities
{
    public class Cidade
    {
        public Cidade()
        {
            CidadeId = Guid.NewGuid();
        }

        public Guid CidadeId { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
