using Microsoft.Extensions.Configuration;
using Pilates.Adapter.Map.CadastroBaseAparelho;
using Pilates.Dapper.Repositories.Aparelho;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseAparelho;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pilates.Application.Services.Aparelho
{
    public class ApplicationServiceAparelho : IApplicationServiceAparelho
    {

        private readonly IServiceAparelho _serviceAparelho;
        private readonly IMapperAparelho _mapperAparelho;

        private readonly AparelhoRepository _aparelhoRepository;

        public ApplicationServiceAparelho(
            IServiceAparelho serviceAparelho,
            IMapperAparelho mapperAparelho,
            IConfiguration configuration)
        {
            _serviceAparelho = serviceAparelho;
            _mapperAparelho = mapperAparelho;
            _aparelhoRepository = new AparelhoRepository(configuration);
        }

        public void DeleteById(Guid id)
        {
            _serviceAparelho.DeleteById(id);
        }

        public IEnumerable<AparelhoDTO> GetAll()
        {
            //return await _mapperAparelho.MapperListAparelhos(_serviceAparelho.GetAll());
            return _aparelhoRepository.GetAll().ToList();
        }

        public AparelhoDTO GetById(Guid id)
        {
            return _mapperAparelho.MapperToDTO(_serviceAparelho.GetById(id));
        }

        public void Save(AparelhoDTO input)
        {
            _serviceAparelho.Save(_mapperAparelho.MapperToEntity(input));
        }

        public void Update(AparelhoDTO input)
        {
            _serviceAparelho.Update(_mapperAparelho.MapperToEntity(input));
        }
    }
}
