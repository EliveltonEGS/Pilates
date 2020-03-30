using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAluno;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseAluno
{
    public class ServiceAluno : ServiceBase<Aluno>, IServiceAluno
    {

        private readonly IRepositoryAluno _repositoryAluno;

        public ServiceAluno(IRepositoryAluno repositoryAluno)
            : base (repositoryAluno)
        {
            _repositoryAluno = repositoryAluno;
        }
    }
}
