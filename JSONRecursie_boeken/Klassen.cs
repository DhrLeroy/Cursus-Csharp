using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONRecursie_boeken
{
    public class Boek
    {
        public string Titel { get; set; }
        public List<Auteur> Auteurs { get; set; } = new List<Auteur>();
    }
    public class Auteur
    {
        public string Naam { get; set; }
        public List<Boek> Boeken { get; set; } = new List<Boek>();
    }
}
