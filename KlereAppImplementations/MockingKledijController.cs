using KlereApp_klassen;
using KlereAppInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlereAppImplementations
{
    public class MockingKledijController : IKledijLogic
    {
        public List<Kledij> GeefAlleKledij()
        {
            var kledij = new List<Kledij>();
            var broekSpringfield = new Kledij("Blauw", "Broek", "Springfield", 32, 33);
            var truiAdidas = new Kledij("Wit", "Trui", "Adidas", 40, 41, 43);
            var tshirtDecathlon = new Kledij("Groen", "T-shirt", "Decathlon", 38, 39);
            kledij.Add(broekSpringfield);
            kledij.Add(truiAdidas);
            kledij.Add(tshirtDecathlon);
            return kledij;
        }
    }
}
