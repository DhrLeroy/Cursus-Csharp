using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Classes
{
    public class Gebruiker
    {
        public string Username { get; set; }
        public List<Aankoop> Aankopen { get; set; }
    }
}
