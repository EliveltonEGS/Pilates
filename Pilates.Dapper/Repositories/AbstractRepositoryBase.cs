using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Pilates.Dapper.Repositories
{
    public abstract class AbstractRepositoryBase<TEntity> where TEntity : class
    {
        private string _connectionString;
        protected string ConnectionString => _connectionString;

        public AbstractRepositoryBase(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public abstract IEnumerable<TEntity> GetAll();
    }
}
