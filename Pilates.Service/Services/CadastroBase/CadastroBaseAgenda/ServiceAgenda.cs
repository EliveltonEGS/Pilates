using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAgenda;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseAgenda
{
    public class ServiceAgenda : ServiceBase<Agenda>, IServiceAgenda
    {

        private readonly IRepositoryAgenda _repositoryAgenda;

        public ServiceAgenda(IRepositoryAgenda repositoryAgenda)
            : base(repositoryAgenda)
        {
            _repositoryAgenda = repositoryAgenda;
        }
    }
}
