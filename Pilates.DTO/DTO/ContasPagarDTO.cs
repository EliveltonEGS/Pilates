using System;

namespace Pilates.DTO.DTO
{
    public class ContasPagarDTO : EntityBaseDTO
    {
        public string StatusPagamento { get; set; }
        public bool Liberado { get; set; }
        public Guid MatriculaId { get; set; }
        public MatriculaDTO MatriculaDTO { get; set; }
    }
}
