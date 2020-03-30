using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Matricula
{
    public interface IApplicationServiceMatricula
    {
        Task<IEnumerable<MatriculaDTO>> GetAll();
        void Update(MatriculaDTO input);
        void DeleteById(Guid id);
        MatriculaDTO GetById(Guid id);
        void Save(MatriculaDTO input);
    }
}
