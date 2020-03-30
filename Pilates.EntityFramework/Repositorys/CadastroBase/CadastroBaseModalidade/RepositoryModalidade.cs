using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseModalidade
{
    public class RepositoryModalidade : RepositoryBase<Modalidade>, IRepositoryModalidade
    {

        private readonly DataContext _context;

        public RepositoryModalidade(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
