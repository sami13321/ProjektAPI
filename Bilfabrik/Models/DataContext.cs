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

        public DbSet<Lagledare> Lagledare { get; set; }

        public DbSet<Stämpel> Stämpel { get; set; }

        public DbSet<StämpeltoUser> StämpeltoUsers { get; set; }
}
}
