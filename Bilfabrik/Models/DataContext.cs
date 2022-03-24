using Microsoft.EntityFrameworkCore;

namespace Bilfabrik.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }


        public DbSet<User> Users { get; set; }

        public DbSet<Montör> Montörer { get; set; }
    }
}
