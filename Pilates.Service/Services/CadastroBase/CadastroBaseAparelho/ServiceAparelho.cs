using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAparelho;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseAparelho
{
    public class ServiceAparelho : ServiceBase<Aparelho>, IServiceAparelho
    {

        private readonly IRepositoryAparelho _repositoryAparelho;

        public ServiceAparelho(IRepositoryAparelho repositoryAparelho)
            : base (repositoryAparelho)
        {
            _repositoryAparelho = repositoryAparelho;
        }
    }
}
