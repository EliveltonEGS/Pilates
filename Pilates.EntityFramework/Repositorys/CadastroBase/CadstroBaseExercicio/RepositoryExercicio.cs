using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadstroBaseExercicio
{
    public class RepositoryExercicio : RepositoryBase<Exercicio>, IRepositoryExercicio
    {

        private readonly DataContext _context;

        public RepositoryExercicio(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
