using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Leeftijd { get; set; }
        public string Email { get; set; }
    }

    public class Leerling : Persoon
    {
        public string Klas { get; set; }
    }

    public class Personeelslid : Persoon
    {
        public int Salaris { get; set; }
    }

    public class Leerkracht : Personeelslid
    {
        public string Vak { get; set; }
    }
}
