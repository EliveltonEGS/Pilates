using Pilates.Adapter.Map.CadastroBaseSala;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseSala;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Sala
{
    public class ApplicationServiceSala : IApplicationServiceSala
    {

        private readonly IServiceSala _serviceSala;
        private readonly IMapperSala _mapperSala;

        public ApplicationServiceSala(
            IServiceSala serviceSala,
            IMapperSala mapperSala)
        {
            _serviceSala = serviceSala;
            _mapperSala = mapperSala;
        }

        public void DeleteById(Guid id)
        {
            _serviceSala.DeleteById(id);
        }

        public async Task<IEnumerable<SalaDTO>> GetAll()
        {
            return await _mapperSala.MapperListSalas(_serviceSala.GetAll());
        }

        public SalaDTO GetById(Guid id)
        {
            return _mapperSala.MapperToDTO(_serviceSala.GetById(id));
        }

        public void Save(SalaDTO input)
        {
            _serviceSala.Save(_mapperSala.MapperToEntity(input));
        }

        public void Update(SalaDTO input)
        {
            _serviceSala.Update(_mapperSala.MapperToEntity(input));
        }
    }
}
