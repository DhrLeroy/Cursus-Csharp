using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursie
{
    internal class Persoon
    {
        public static string Taal = "Nl";
        public int Leeftijd {  get; set; }

        public void ToonLeeftijd()
        {
            Console.WriteLine(Leeftijd);
        }

        public static void ZegHallo()
        {
            if (Taal == "Nl")
                Console.WriteLine("Hallo");
            else if(Taal == "Sp")
                Console.WriteLine("Ola");
        }
    }
}
