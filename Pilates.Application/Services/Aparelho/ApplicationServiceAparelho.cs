using Pilates.Adapter.Map.CadastroBaseAparelho;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseAparelho;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Aparelho
{
    public class ApplicationServiceAparelho : IApplicationServiceAparelho
    {

        private readonly IServiceAparelho _serviceAparelho;
        private readonly IMapperAparelho _mapperAparelho;

        public ApplicationServiceAparelho(
            IServiceAparelho serviceAparelho,
            IMapperAparelho mapperAparelho)
        {
            _serviceAparelho = serviceAparelho;
            _mapperAparelho = mapperAparelho;
        }

        public void DeleteById(Guid id)
        {
            _serviceAparelho.DeleteById(id);
        }

        public async Task<IEnumerable<AparelhoDTO>> GetAll()
        {
            return await _mapperAparelho.MapperListAparelhos(_serviceAparelho.GetAll());
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
