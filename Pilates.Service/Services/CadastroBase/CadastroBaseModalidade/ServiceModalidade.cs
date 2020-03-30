using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseModalidade;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseModalidade
{
    public class ServiceModalidade : ServiceBase<Modalidade>, IServiceModalidade
    {

        private readonly IRepositoryModalidade _repositoryModalidade;

        public ServiceModalidade(IRepositoryModalidade repositoryModalidade)
            : base (repositoryModalidade)
        {
            _repositoryModalidade = repositoryModalidade;
        }
    }
}
