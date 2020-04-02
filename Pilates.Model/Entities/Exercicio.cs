using System;

namespace Pilates.Model.Entities
{
    public class Exercicio
    {
        public Exercicio()
        {
            ExercicioId = Guid.NewGuid();
        }

        public Guid ExercicioId { get; set; }
        public string Descricao { get; set; }
        public Guid AparelhoId { get; set; }
        public Aparelho Aparelho { get; set; }
    }
}
