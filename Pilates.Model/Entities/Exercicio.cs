using System;

namespace Pilates.Model.Entities
{
    public class Exercicio : EntityBase
    {
        public string Descricao { get; set; }
        public Guid AparelhoId { get; set; }
        public Aparelho Aparelho { get; set; }
    }
}
