using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg_LINQ
{
    internal class Connectie : DbContext
    {
        public DbSet<Pokémon> Pokémons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

            optionsBuilder.UseMySql("server=localhost;database=Pokemon_LINQ;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
