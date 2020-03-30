using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseEndereco
{
    public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
    {

        private readonly DataContext _context;

        public RepositoryEndereco(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
