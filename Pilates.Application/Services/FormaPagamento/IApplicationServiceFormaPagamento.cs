using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.FormaPagamento
{
    public interface IApplicationServiceFormaPagamento
    {
        Task<IEnumerable<FormaPagamentoDTO>> GetAll();
        void Update(FormaPagamentoDTO input);
        void DeleteById(Guid id);
        FormaPagamentoDTO GetById(Guid id);
        void Save(FormaPagamentoDTO input);
    }
}
