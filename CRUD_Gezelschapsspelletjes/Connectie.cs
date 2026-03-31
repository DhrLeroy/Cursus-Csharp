using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Gezelschapsspelletjes
{
    internal class Connectie : DbContext
    {
        public DbSet<Gezelschapsspel> Gezelschapsspelletjes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("password=Peppa123$;user=root;server=localhost;database=GezelschapsCRUD",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
