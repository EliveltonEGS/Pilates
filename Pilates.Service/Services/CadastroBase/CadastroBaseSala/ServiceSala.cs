using Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseSala;
using Pilates.Model.Entities;

namespace Pilates.Service.Services.CadastroBase.CadastroBaseSala
{
    public class ServiceSala : ServiceBase<Sala>, IServiceSala
    {

        private readonly IRepositorySala _repositorySala;

        public ServiceSala(IRepositorySala repositorySala)
            : base (repositorySala)
        {
            _repositorySala = repositorySala;
        }
    }
}
