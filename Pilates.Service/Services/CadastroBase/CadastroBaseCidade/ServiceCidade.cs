using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseCidade;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseCidade
{
    public class ServiceCidade : ServiceBase<Cidade>, IServiceCidade
    {

        private readonly IRepositoryCidade _repositoryCidade;

        public ServiceCidade(IRepositoryCidade repositoryCidade)
            : base (repositoryCidade)
        {
            _repositoryCidade = repositoryCidade;
        }
    }
}
