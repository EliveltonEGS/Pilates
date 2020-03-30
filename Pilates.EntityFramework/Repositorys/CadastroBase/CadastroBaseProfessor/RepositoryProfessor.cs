using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseProfessor
{
    public class RepositoryProfessor : RepositoryBase<Professor>, IRepositoryProfessor
    {

        private readonly DataContext _context;

        public RepositoryProfessor(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
