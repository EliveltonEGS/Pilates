using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Especialidade
{
    public interface IApplicationServiceEspecialidade
    {
        Task<IEnumerable<EspecialidadeDTO>> GetAll();
        void Update(EspecialidadeDTO input);
        void DeleteById(Guid id);
        EspecialidadeDTO GetById(Guid id);
        void Save(EspecialidadeDTO input);
    }
}
