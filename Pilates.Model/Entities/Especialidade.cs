using System;

namespace Pilates.Model.Entities
{
    public class Especialidade
    {
        public Especialidade()
        {
            EspecialidadeId = Guid.NewGuid();
        }

        public Guid EspecialidadeId { get; set; }
        public string Descricao { get; set; }
    }
}
