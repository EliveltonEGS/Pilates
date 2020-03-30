using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAgenda
{
    public class RepositoryAgenda : RepositoryBase<Agenda>, IRepositoryAgenda
    {

        private readonly DataContext _context;

        public RepositoryAgenda(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
