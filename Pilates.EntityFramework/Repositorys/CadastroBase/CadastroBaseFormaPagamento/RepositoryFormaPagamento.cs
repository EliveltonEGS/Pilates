using Pilates.EntityFramework.Data;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Repositorys.CadastroBase.CadastroBaseFormaPagamento
{
    public class RepositoryFormaPagamento : RepositoryBase<FormaPagamento>, IRepositoryFormaPagamento
    {

        private readonly DataContext _context;

        public RepositoryFormaPagamento(DataContext context)
            : base (context)
        {
            _context = context;
        }
    }
}
