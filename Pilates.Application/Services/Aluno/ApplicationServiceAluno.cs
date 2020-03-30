
using Pilates.Adapter.Map.CadastroBaseAluno;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseAluno;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.Aluno
{
    public class ApplicationServiceAluno : IApplicationServiceAluno
    {
        private readonly IServiceAluno _serviceAluno;
        private readonly IMapperAparelho _mapperAluno;

        public ApplicationServiceAluno(
            IServiceAluno serviceAluno,
            IMapperAparelho mapperAluno)
        {
            _serviceAluno = serviceAluno;
            _mapperAluno = mapperAluno;
        }

        public void DeleteById(Guid id)
        {
            _serviceAluno.DeleteById(id);
        }

        public async Task<IEnumerable<AlunoDTO>> GetAll()
        {
            return await _mapperAluno.MapperListAlunos(_serviceAluno.GetAll());
        }

        public AlunoDTO GetById(Guid id)
        {
            return _mapperAluno.MapperToDTO(_serviceAluno.GetById(id));
        }

        public void Save(AlunoDTO input)
        {
            _serviceAluno.Save(_mapperAluno.MapperToEntity(input));
        }

        public void Update(AlunoDTO input)
        {
            _serviceAluno.Update(_mapperAluno.MapperToEntity(input));
        }
    }
}
