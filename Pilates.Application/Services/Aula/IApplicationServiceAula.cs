using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Aula
{
    public interface IApplicationServiceAula
    {
        Task<IEnumerable<AulaDTO>> GetAll();
        void Update(AulaDTO input);
        void DeleteById(Guid id);
        AulaDTO GetById(Guid id);
        void Save(AulaDTO input);
    }
}
