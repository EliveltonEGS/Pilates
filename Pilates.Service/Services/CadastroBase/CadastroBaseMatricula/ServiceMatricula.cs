using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseMatricula;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseMatricula
{
    public class ServiceMatricula : ServiceBase<Matricula>, IServiceMatricula
    {

        private readonly IRepositoryMatricula _repositoryMatricula;

        public ServiceMatricula(IRepositoryMatricula repositoryMatricula)
            : base(repositoryMatricula)
        {
            _repositoryMatricula = repositoryMatricula;
        }
    }
}
