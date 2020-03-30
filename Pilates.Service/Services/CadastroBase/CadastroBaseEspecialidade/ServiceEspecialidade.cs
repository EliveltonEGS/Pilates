using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEspecialidade;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseEspecialidade
{
    public class ServiceEspecialidade : ServiceBase<Especialidade>, IServiceEspecialidade
    {

        private readonly IRepositoryEspecialidade _repositoryEspecialidade;

        public ServiceEspecialidade(IRepositoryEspecialidade repositoryEspecialidade)
            : base (repositoryEspecialidade)
        {
            _repositoryEspecialidade = repositoryEspecialidade;
        }
    }
}
