using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class DbFactory : IDesignTimeDbContextFactory<Databank>
    {
        public Databank CreateDbContext(string[] args)
        {
            return new Databank();
        }
    }
}
