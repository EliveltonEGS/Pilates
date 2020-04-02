using System;

namespace Pilates.Model.Entities
{
    public class Aparelho
    {
        public Aparelho()
        {
            AparelhoId = Guid.NewGuid();
        }

        public Guid AparelhoId { get; set; }
        public string Descricao { get; set; }
    }
}
