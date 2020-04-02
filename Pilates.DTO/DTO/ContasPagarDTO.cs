using System;

namespace Pilates.DTO.DTO
{
    public class ContasPagarDTO
    {
        public ContasPagarDTO()
        {
            ContasPagarId = Guid.NewGuid();
        }

        public Guid ContasPagarId { get; set; }
        public string StatusPagamento { get; set; }
        public bool Liberado { get; set; }
        public Guid MatriculaId { get; set; }
        public MatriculaDTO MatriculaDTO { get; set; }
    }
}
