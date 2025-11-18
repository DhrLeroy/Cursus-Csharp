using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakkerij
{
    public class Bakkerij
    {
        public List<Taart> Taarten { get; set; }
        public List<Bakkerijproduct> Bakkerijproducten { get; set; }

        public int Bereken_aantal_taarten(string naam, int aantal_personen)
        {
            foreach (var taart in Taarten)
            {
                if (taart.Naam.Equals(naam, StringComparison.CurrentCultureIgnoreCase))
                {
                    var taarten = aantal_personen / taart.Aantal_personen;
                    if (Convert.ToSingle(aantal_personen) / taart.Aantal_personen % 1 != 0)
                    {
                        taarten++;
                    }
                    return taarten;
                }
            }
            return 0;
        }

        public void BerekenPrijs(string naam, bool glutenvrij)
        {
            foreach(var product in Bakkerijproducten)
            {
                if(product.Naam.Equals(naam, StringComparison.CurrentCultureIgnoreCase))
                {
                    var extra = 0;
                    if(!product.Glutenvrij && glutenvrij)
                    {
                        extra = 30;
                    }
                    var prijs = product.Prijs * (100 + extra) / 100;
                    Console.WriteLine($"Prijs: {prijs}");
                }
            }
            Console.WriteLine($"Product {naam} niet gevonden.");
        }
    }

    public class Bakkerijproduct
    {
        public Bakkerijproduct(string naam, float prijs, bool glutenvrij)
        {
            Naam = naam;
            Prijs = prijs;
            Glutenvrij = glutenvrij;
        }

        public string Naam { get; set; }
        public float Prijs { get; set; }
        public bool Glutenvrij { get; set; }

    }

    public class Taart : SuikerarmMogelijk
    {
        public Taart(int aantal_personen, string hoofdingredient, string naam, float prijs, bool glutenvrij, bool suikerarm) : base(naam, prijs, glutenvrij, suikerarm)
        {
            Aantal_personen = aantal_personen;
            Hoofdingredient = hoofdingredient;
        }

        public int Aantal_personen { get; set; }
        public string Hoofdingredient { get; set; }

    }

    public class SuikerarmMogelijk : Bakkerijproduct {
        public SuikerarmMogelijk(string naam, float prijs, bool glutenvrij,bool suikerarm) : base(naam,prijs,glutenvrij)
        {
            Suikerarm = suikerarm;
        }

        public bool Suikerarm { get; set; }
    }

    public class Patisserie : SuikerarmMogelijk
    {
        public bool Extra_chocolade { get; set; }
        public Patisserie(bool extra_chocolade, string naam, float prijs, bool glutenvrij, bool suikerarm) : base(naam, prijs, glutenvrij, suikerarm)
        {
            Extra_chocolade = extra_chocolade;
        }

    }

}
