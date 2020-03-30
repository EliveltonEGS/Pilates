using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAula
{
    public class RepositoryAula : RepositoryBase<Aula>, IRepositoryAula
    {

        private readonly DataContext _context;

        public RepositoryAula(DataContext context)
            : base ( context)
        {
            _context = context;
        }
    }
}
