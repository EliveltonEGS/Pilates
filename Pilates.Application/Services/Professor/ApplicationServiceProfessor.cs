using Pilates.Adapter.Map.CadastroBaseProfessor;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseProfessor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Professor
{
    public class ApplicationServiceProfessor : IApplicationServiceProfessor
    {

        private readonly IServiceProfessor _serviceProfessor;
        private readonly IMapperProfessor _mapperProfessor;

        public ApplicationServiceProfessor(
            IServiceProfessor serviceProfessor,
            IMapperProfessor mapperProfessor)
        {
            _serviceProfessor = serviceProfessor;
            _mapperProfessor = mapperProfessor;
        }

        public void DeleteById(Guid id)
        {
            _serviceProfessor.DeleteById(id);
        }

        public async Task<IEnumerable<ProfessorDTO>> GetAll()
        {
            return await _mapperProfessor.MapperListProfessor(_serviceProfessor.GetAll());
        }

        public ProfessorDTO GetById(Guid id)
        {
            return _mapperProfessor.MapperToDTO(_serviceProfessor.GetById(id));
        }

        public void Save(ProfessorDTO input)
        {
            _serviceProfessor.Save(_mapperProfessor.MapperToEntity(input));
        }

        public void Update(ProfessorDTO input)
        {
            _serviceProfessor.Update(_mapperProfessor.MapperToEntity(input));
        }
    }
}
