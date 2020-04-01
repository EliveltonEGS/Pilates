using Pilates.Adapter.Map.CadastroBaseEspecialidade;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseEspecialidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Especialidade
{
    public class ApplicationServiceEspecialidade : IApplicationServiceEspecialidade
    {

        private readonly IServiceEspecialidade _serviceEspecialidade;
        private readonly IMapperEspecialidade _mapperEspecialidade;

        public ApplicationServiceEspecialidade(
            IServiceEspecialidade serviceEspecialidade,
            IMapperEspecialidade mapperEspecialidade)
        {
            _serviceEspecialidade = serviceEspecialidade;
            _mapperEspecialidade = mapperEspecialidade;
        }

        public void DeleteById(Guid id)
        {
            _serviceEspecialidade.DeleteById(id);
        }

        public async Task<IEnumerable<EspecialidadeDTO>> GetAll()
        {
            return await _mapperEspecialidade.MapperListEspecialidades(_serviceEspecialidade.GetAll());
        }

        public EspecialidadeDTO GetById(Guid id)
        {
            return _mapperEspecialidade.MapperToDTO(_serviceEspecialidade.GetById(id));
        }

        public void Save(EspecialidadeDTO input)
        {
            _serviceEspecialidade.Save(_mapperEspecialidade.MapperToEntity(input));
        }

        public void Update(EspecialidadeDTO input)
        {
            _serviceEspecialidade.Update(_mapperEspecialidade.MapperToEntity(input));
        }
    }
}
