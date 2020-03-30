using Pilates.Adapter.Map.CadastroBaseAgenda;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseAgenda;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Agenda
{
    public class ApplicationServiceAgenda : IApplicationServiceAgenda
    {

        private readonly IServiceAgenda _serviceAgenda;
        private readonly IMapperAgenda _mapperAgenda;

        public ApplicationServiceAgenda(
            IServiceAgenda serviceAgenda,
            IMapperAgenda mapperAgenda)
        {
            _serviceAgenda = serviceAgenda;
            _mapperAgenda = mapperAgenda;
        }

        public void DeleteById(Guid id)
        {
            _serviceAgenda.DeleteById(id);
        }

        public async Task<IEnumerable<AgendaDTO>> GetAll()
        {
            return await _mapperAgenda.MapperListAgendas(_serviceAgenda.GetAll());
        }

        public AgendaDTO GetById(Guid id)
        {
            return _mapperAgenda.MapperToDTO(_serviceAgenda.GetById(id));
        }

        public void Save(AgendaDTO input)
        {
            _serviceAgenda.Save(_mapperAgenda.MapperToEntity(input));
        }

        public void Update(AgendaDTO input)
        {
            _serviceAgenda.Update(_mapperAgenda.MapperToEntity(input));
        }
    }
}
