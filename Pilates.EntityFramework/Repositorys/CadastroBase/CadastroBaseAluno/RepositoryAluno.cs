using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseAluno
{
    public  class RepositoryAluno : RepositoryBase<Aluno>, IRepositoryAluno
    {

        private readonly DataContext _context;

        public RepositoryAluno(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
