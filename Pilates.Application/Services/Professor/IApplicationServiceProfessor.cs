using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Professor
{
    public interface IApplicationServiceProfessor
    {
        Task<IEnumerable<ProfessorDTO>> GetAll();
        void Update(ProfessorDTO input);
        void DeleteById(Guid id);
        ProfessorDTO GetById(Guid id);
        void Save(ProfessorDTO input);
    }
}
