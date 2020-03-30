using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAula;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseAula
{
    public class ServiceAula : ServiceBase<Aula>, IServiceAula
    {

        private readonly IRepositoryAula _repositoryAula;

        public ServiceAula(IRepositoryAula repositoryAula)
            : base (repositoryAula)
        {
            _repositoryAula = repositoryAula;
        }
    }
}
