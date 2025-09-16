using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Classes
{
    public class Aankoop
    {
        public Game Game { get; set; }
        public int GameId { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public string Username { get; set; }
    }
}
