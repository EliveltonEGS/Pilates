using Pilates.EntityFramework.Repositorys.CadastroBase.CadstroBaseExercicio;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseExercicio
{
    public class ServiceExercicio : ServiceBase<Exercicio>, IServiceExercicio
    {

        private readonly IRepositoryExercicio _repositoryExercicio;

        public ServiceExercicio(IRepositoryExercicio repositoryExercicio)
            : base (repositoryExercicio)
        {
            _repositoryExercicio = repositoryExercicio;
        }
    }
}
