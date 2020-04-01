using Pilates.Adapter.Map.CadastroBaseAula;
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
        private readonly IMapperAula _mapperAula;

        public ApplicationServiceAula(
            IServiceAula serviceAula,
            IMapperAula mapperAula)
        {
            _mapperAula = mapperAula;
            _serviceAula = serviceAula;
        }

        public void DeleteById(Guid id)
        {
            _serviceAula.DeleteById(id);
        }

        public async Task<IEnumerable<AulaDTO>> GetAll()
        {
            return await _mapperAula.MapperListAulas(_serviceAula.GetAll());
        }

        public AulaDTO GetById(Guid id)
        {
            return _mapperAula.MapperToDTO(_serviceAula.GetById(id));
        }

        public void Save(AulaDTO input)
        {
            _serviceAula.Save(_mapperAula.MapperToEntity(input));
        }

        public void Update(AulaDTO input)
        {
            _serviceAula.Update(_mapperAula.MapperToEntity(input));
        }
    }
}
