using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Cidade
{
    public interface IApplicationServiceCidade
    {
        Task<IEnumerable<CidadeDTO>> GetAll();
        void Update(CidadeDTO input);
        void DeleteById(Guid id);
        CidadeDTO GetById(Guid id);
        void Save(CidadeDTO input);
    }
}
