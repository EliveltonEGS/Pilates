using Pilates.EntityFramework.Repositorys.CadastroBase.CasdastroBaseContasPagar;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseContasPagar
{
    public class ServiceContasPagar : ServiceBase<ContasPagar>, IServiceContasPagar
    {

        private readonly IRepositoryContasPagar _repositoryContasPagar;

        public ServiceContasPagar(IRepositoryContasPagar repositoryContasPagar)
            : base (repositoryContasPagar)
        {
            _repositoryContasPagar = repositoryContasPagar;
        }
    }
}
