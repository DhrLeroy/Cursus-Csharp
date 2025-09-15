using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_12___Databanken__geavanceerd_
{
    public class DatabankFactory : IDesignTimeDbContextFactory<Databank>
    {
        public Databank CreateDbContext(string[] args)
        {
            return new Databank();

        }
    }
}
