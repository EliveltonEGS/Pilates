using System;

namespace Pilates.Model.Entities
{
    public class Modalidade
    {
        public Modalidade()
        {
            ModalidadeId = Guid.NewGuid();
        }

        public Guid ModalidadeId { get; set; }
        public string Descricao { get; set; }
    }
}
