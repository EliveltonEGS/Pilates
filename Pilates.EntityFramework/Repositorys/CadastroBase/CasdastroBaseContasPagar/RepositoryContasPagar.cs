using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CasdastroBaseContasPagar
{
    public class RepositoryContasPagar : RepositoryBase<ContasPagar>, IRepositoryContasPagar
    {

        private readonly DataContext _context;

        public RepositoryContasPagar(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
