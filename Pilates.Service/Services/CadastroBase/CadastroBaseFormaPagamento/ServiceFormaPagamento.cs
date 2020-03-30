using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseFormaPagamento;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseFormaPagamento
{
    public class ServiceFormaPagamento : ServiceBase<FormaPagamento>, IServiceFormaPagamento
    {

        private readonly IRepositoryFormaPagamento _repositoryFormaPagamento;

        public ServiceFormaPagamento(IRepositoryFormaPagamento repositoryFormaPagamento)
            : base (repositoryFormaPagamento)
        {
            _repositoryFormaPagamento = repositoryFormaPagamento;
        }
    }
}
