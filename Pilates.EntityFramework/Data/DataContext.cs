using Microsoft.EntityFrameworkCore;

namespace Pilates.EntityFramework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {

        }
    }
}
