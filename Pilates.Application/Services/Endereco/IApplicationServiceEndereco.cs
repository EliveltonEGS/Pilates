using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Endereco
{
    public interface IApplicationServiceEndereco
    {
        Task<IEnumerable<EnderecoDTO>> GetAll();
        void Update(EnderecoDTO input);
        void DeleteById(Guid id);
        EnderecoDTO GetById(Guid id);
        void Save(EnderecoDTO input);
    }
}
