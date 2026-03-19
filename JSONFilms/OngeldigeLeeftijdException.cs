using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONFilms
{
    public class Persoon
    {
        public string Naam { get; set; }
        private int leeftijd;

        public int Leeftijd
        {
            get { return leeftijd; }
            set {
                if (value < 0)
                    throw new OngeldigeLeeftijdException("Leeftijd mag niet negatief zijn.");
                leeftijd = value;
            }
        }

    }
    public class OngeldigeLeeftijdException : Exception
    {
        public OngeldigeLeeftijdException(string boodschap) : base(boodschap) { }
    }
}
