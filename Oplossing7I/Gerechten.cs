using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7I
{

    public class Bestelling
    {
        public float Saldo_Betaald { get; set; }
        public List<Gerecht> BesteldeGerechten { get; set; }

        public Bestelling(params Gerecht[] gerechten)
        {
            BesteldeGerechten = gerechten.ToList();
            Saldo_Betaald = 0;
        }

        public float BerekenTotaal()
        {
            float totaal = 0;
            foreach(var gerecht in BesteldeGerechten)
            {
                totaal += gerecht.Prijs;
            }
            return totaal;
        }

        public void BetaalSaldo(float bedrag)
        {
            Saldo_Betaald += bedrag;

            var openstaandSaldo = BerekenOpenstaandSaldo();
            if(openstaandSaldo > 0)
            {
                Console.WriteLine($"Je moet nog {openstaandSaldo} euro betalen.");
            }
            else
            {
                Console.WriteLine($"Je krijgt {openstaandSaldo * -1} euro terug.");
                Saldo_Betaald += openstaandSaldo;

            }
        }

        public float BerekenFooi(int percentage)
        {
            return BerekenTotaal() / 100 * percentage;
        }

        public float BerekenOpenstaandSaldo()
        {
            return BerekenTotaal() - Saldo_Betaald;
        }


    }

    public class Gerecht
    {
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public int MinimumPersonen { get; set; }

        public Gerecht(string naam, float prijs, int minimumPersonen)
        {
            Naam = naam;
            Prijs = prijs;
            MinimumPersonen = minimumPersonen;
        }

        public float BerekenPrijs(int aantal_personen)
        {
            var totaal = Prijs * aantal_personen;
            if (aantal_personen < MinimumPersonen)
            {
                Console.WriteLine($"Dit gaat niet. U moet voor minstens {MinimumPersonen} personen dit gerecht bestellen.");
                totaal = 0;
            }
            return totaal;
        }

        public void ToonGerecht()
        {
            string print = $"{Naam}";
            if(MinimumPersonen > 1)
            {
                print = $"{print} (minstens {MinimumPersonen} personen)";
            }
            print = $"{print}: {Prijs} euro";

            if (MinimumPersonen > 1)
            {
                print = $"{print} p.p.";
            }
            Console.WriteLine(print);

        }
    }

    public class Voorgerecht : Gerecht
    {

        public Voorgerecht(string naam, float prijs, int minimumPersonen, bool isVeganistisch) : base(naam, prijs, minimumPersonen)
        {
            IsVeganistisch = isVeganistisch;
        }

        public bool IsVeganistisch { get; set; }

    }

    public class Hoofdgerecht : Gerecht
    {
        public Hoofdgerecht(string naam, float prijs, int minimumPersonen, string categorie, params string[] ingrediënten) : base(naam, prijs, minimumPersonen)
        {
            Ingrediënten = ingrediënten.ToList();
            Categorie = categorie;
        }

        public List<string> Ingrediënten { get; set; }
        public string Categorie { get; set; }
    }

    public class Nagerecht : Gerecht
    {
        public bool KanKindergerechtZijn { get; set; }

        public Nagerecht(string naam, float prijs, int minimumPersonen, bool kanKindergerechtZijn) : base(naam, prijs, minimumPersonen)
        {
            KanKindergerechtZijn = kanKindergerechtZijn;
        }

        public float BerekenPrijsDessert(int kinderen)
        {
            var prijs = Prijs;
            if (KanKindergerechtZijn && kinderen > 0)
            {
                prijs = prijs - 3;
            }
            if (!KanKindergerechtZijn && kinderen > 0)
            {
                Console.WriteLine("Dit gerecht is niet beschikbaar voor kinderen.");
            }
            return prijs*kinderen;
        }
    }
}
