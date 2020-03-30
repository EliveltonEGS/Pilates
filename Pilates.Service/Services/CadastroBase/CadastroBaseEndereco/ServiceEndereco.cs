using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEndereco;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseEndereco
{
    public class ServiceEndereco : ServiceBase<Endereco>, IServiceEndereco
    {

        private readonly IRepositoryEndereco _repositoryEndereco;

        public ServiceEndereco(IRepositoryEndereco repositoryEndereco)
            : base (repositoryEndereco)
        {
            _repositoryEndereco = repositoryEndereco;
        }
    }
}
