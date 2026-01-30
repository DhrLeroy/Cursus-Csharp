using Microsoft.EntityFrameworkCore;

namespace F1_Databank
{
    public class Databank : DbContext
    {
        public DbSet<GP> GPs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;database=f1;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
