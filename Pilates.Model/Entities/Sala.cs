using System;

namespace Pilates.Model.Entities
{
    public class Sala
    {
        public Sala()
        {
            SalaId = Guid.NewGuid();
        }

        public Guid SalaId { get; set; }
        public string Descricao { get; set; }
    }
}
