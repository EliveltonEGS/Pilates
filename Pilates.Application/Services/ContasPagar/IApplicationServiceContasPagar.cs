using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.ContasPagar
{
    public interface IApplicationServiceContasPagar
    {
        Task<IEnumerable<ContasPagarDTO>> GetAll();
        void Update(ContasPagarDTO input);
        void DeleteById(Guid id);
        ContasPagarDTO GetById(Guid id);
        void Save(ContasPagarDTO input);
    }
}
