using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAparelho
{
    public class RepositoryAparelho : RepositoryBase<Aparelho>, IRepositoryAparelho
    {

        private readonly DataContext _context;

        public RepositoryAparelho(DataContext context)
            : base (context)
        {
            _context = context;
        }


    }
}
