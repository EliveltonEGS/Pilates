using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseCidade
{
    public class RepositoryCidade: RepositoryBase<Cidade>, IRepositoryCidade
    {

        private readonly DataContext _context;

        public RepositoryCidade(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
