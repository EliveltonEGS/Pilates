using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseAula;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Aula
{
    public class ApplicationServiceAula : IApplicationServiceAula
    {

        private readonly IServiceAula _serviceAula;

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AulaDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public AulaDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(AulaDTO input)
        {
            throw new NotImplementedException();
        }

        public void Update(AulaDTO input)
        {
            throw new NotImplementedException();
        }
    }
}
