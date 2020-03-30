using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Aluno
{
    public interface IApplicationServiceAluno
    {
        Task<IEnumerable<AlunoDTO>> GetAll();
        void Update(AlunoDTO input);
        void DeleteById(Guid id);
        AlunoDTO GetById(Guid id);
        void Save(AlunoDTO input);
    }
}
