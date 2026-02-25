using Microsoft.EntityFrameworkCore;

namespace DB_Strips_Databank
{
    public class Connectie : DbContext
    {
        public DbSet<Strip> Strips { get; set; }
        public DbSet<Tekenaar> Tekenaars { get; set; }
        public DbSet<Album> Albums { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;database=strips;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
