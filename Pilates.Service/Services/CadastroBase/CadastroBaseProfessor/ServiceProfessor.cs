using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseProfessor;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseProfessor
{
    public class ServiceProfessor : ServiceBase<Professor>, IServiceProfessor
    {

        private readonly IRepositoryProfessor _repositoryProfessor;

        public ServiceProfessor(IRepositoryProfessor repositoryProfessor)
            : base (repositoryProfessor)
        {
            _repositoryProfessor = repositoryProfessor;
        }
    }
}
