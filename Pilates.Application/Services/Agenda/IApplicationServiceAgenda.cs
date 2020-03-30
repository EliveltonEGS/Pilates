using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Agenda
{
    public interface IApplicationServiceAgenda
    {
        Task<IEnumerable<AgendaDTO>> GetAll();
        void Update(AgendaDTO input);
        void DeleteById(Guid id);
        AgendaDTO GetById(Guid id);
        void Save(AgendaDTO input);
    }
}
