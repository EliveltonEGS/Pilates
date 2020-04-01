using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Sala
{
    public interface IApplicationServiceSala
    {
        Task<IEnumerable<SalaDTO>> GetAll();
        void Update(SalaDTO input);
        void DeleteById(Guid id);
        SalaDTO GetById(Guid id);
        void Save(SalaDTO input);
    }
}
