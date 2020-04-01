using Pilates.Adapter.Map.CadastroBaseEndereco;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseEndereco;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Endereco
{
    public class ApplicationServiceEndereco : IApplicationServiceEndereco
    {

        private readonly IServiceEndereco _serviceEndereco;
        private readonly IMapperEndereco _mapperEndereco;

        public ApplicationServiceEndereco(
            IServiceEndereco serviceEndereco,
            IMapperEndereco mapperEndereco)
        {
            _serviceEndereco = serviceEndereco;
            _mapperEndereco = mapperEndereco;
        }

        public void DeleteById(Guid id)
        {
            _serviceEndereco.DeleteById(id);
        }

        public async Task<IEnumerable<EnderecoDTO>> GetAll()
        {
            return await _mapperEndereco.MapperListEnderecos(_serviceEndereco.GetAll());
        }

        public EnderecoDTO GetById(Guid id)
        {
            return _mapperEndereco.MapperToDTO(_serviceEndereco.GetById(id));
        }

        public void Save(EnderecoDTO input)
        {
            _serviceEndereco.Save(_mapperEndereco.MapperToEntity(input));
        }

        public void Update(EnderecoDTO input)
        {
            _serviceEndereco.Update(_mapperEndereco.MapperToEntity(input));
        }
    }
}
