using Pilates.Adapter.Map.CadastroBaseMatricula;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseMatricula;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Matricula
{
    public class ApplicationServiceMatricula : IApplicationServiceMatricula
    {

        private readonly IServiceMatricula _serviceMatricula;
        private readonly IMapperMatricula _mapperMatricula;

        public ApplicationServiceMatricula(
            IServiceMatricula serviceMatricula,
            IMapperMatricula mapperMatricula)
        {
            _mapperMatricula = mapperMatricula;
            _serviceMatricula = serviceMatricula;
        }

        public void DeleteById(Guid id)
        {
            _serviceMatricula.DeleteById(id);
        }

        public async Task<IEnumerable<MatriculaDTO>> GetAll()
        {
            return await _mapperMatricula.MapperListMatriculas(_serviceMatricula.GetAll());
        }

        public MatriculaDTO GetById(Guid id)
        {
            return _mapperMatricula.MapperToDTO(_serviceMatricula.GetById(id));
        }

        public void Save(MatriculaDTO input)
        {
            _serviceMatricula.Save(_mapperMatricula.MapperToEntity(input));
        }

        public void Update(MatriculaDTO input)
        {
            _serviceMatricula.Update(_mapperMatricula.MapperToEntity(input));
        }
    }
}
