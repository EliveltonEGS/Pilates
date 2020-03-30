using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEspecialidade
{
    public class RepositoryEspecialidade : RepositoryBase<Especialidade>, IRepositoryEspecialidade
    {

        private readonly DataContext _context;

        public RepositoryEspecialidade(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
