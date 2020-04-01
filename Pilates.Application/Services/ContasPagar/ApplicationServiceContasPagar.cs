using Pilates.Adapter.Map.CadastroBaseContasPagar;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseContasPagar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.ContasPagar
{
    public class ApplicationServiceContasPagar : IApplicationServiceContasPagar
    {

        private readonly IServiceContasPagar _serviceContasPagar;
        private readonly IMapperContasPagar _mapperContasPagar;

        public ApplicationServiceContasPagar(
            IServiceContasPagar serviceContasPagar,
            IMapperContasPagar mapperContasPagar)
        {
            _serviceContasPagar = serviceContasPagar;
            _mapperContasPagar = mapperContasPagar;
        }

        public void DeleteById(Guid id)
        {
            _serviceContasPagar.DeleteById(id);
        }

        public async Task<IEnumerable<ContasPagarDTO>> GetAll()
        {
            return await _mapperContasPagar.MapperListContasPagar(_serviceContasPagar.GetAll());
        }

        public ContasPagarDTO GetById(Guid id)
        {
            return _mapperContasPagar.MapperToDTO(_serviceContasPagar.GetById(id));
        }

        public void Save(ContasPagarDTO input)
        {
            _serviceContasPagar.Save(_mapperContasPagar.MapperToEntity(input));
        }

        public void Update(ContasPagarDTO input)
        {
            _serviceContasPagar.Update(_mapperContasPagar.MapperToEntity(input));
        }
    }
}
