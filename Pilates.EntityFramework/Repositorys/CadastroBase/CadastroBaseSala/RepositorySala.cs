using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseSala
{
    public class RepositorySala : RepositoryBase<Sala>, IRepositorySala
    {

        private readonly DataContext _context;

        public RepositorySala(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
