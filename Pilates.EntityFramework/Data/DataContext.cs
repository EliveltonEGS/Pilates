using Microsoft.EntityFrameworkCore;
using Pilates.Model.Entities;

namespace Pilates.EntityFramework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options) { }

        public DbSet<Modalidade> Modalidades { get; set; }
    }
}
