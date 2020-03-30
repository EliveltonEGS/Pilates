using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseMatricula
{
    public class RepositoryMatricula : RepositoryBase<Matricula>, IRepositoryMatricula
    {

        private readonly DataContext _context;

        public RepositoryMatricula(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
