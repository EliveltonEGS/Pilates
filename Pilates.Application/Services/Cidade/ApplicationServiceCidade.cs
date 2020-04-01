using Pilates.Adapter.Map.CadastroBaseCidade;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseCidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Cidade
{
    public class ApplicationServiceCidade : IApplicationServiceCidade
    {

        private readonly IServiceCidade _serviceCidade;
        private readonly IMapperCidade _mapperCidade;

        public ApplicationServiceCidade(
            IMapperCidade mapperCidade,
            IServiceCidade serviceCidade)
        {
            _mapperCidade = mapperCidade;
            _serviceCidade = serviceCidade;
        }

        public void DeleteById(Guid id)
        {
            _serviceCidade.DeleteById(id);
        }

        public async Task<IEnumerable<CidadeDTO>> GetAll()
        {
            return await _mapperCidade.MapperListCidades(_serviceCidade.GetAll());
        }

        public CidadeDTO GetById(Guid id)
        {
            return _mapperCidade.MapperToDTO(_serviceCidade.GetById(id));
        }

        public void Save(CidadeDTO input)
        {
            _serviceCidade.Save(_mapperCidade.MapperToEntity(input));
        }

        public void Update(CidadeDTO input)
        {
            _serviceCidade.Update(_mapperCidade.MapperToEntity(input));
        }
    }
}
