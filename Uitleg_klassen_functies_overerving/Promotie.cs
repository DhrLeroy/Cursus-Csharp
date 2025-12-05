using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg_klassen_functies_overerving
{
    public class Promotie
    {
        public Product Product { get; set; }
        public int TeBetalen { get; set; }
        public int Gratis { get; set; }

        public Promotie(Product product, int teBetalen, int gratis)
        {
            Product = product;
            TeBetalen = teBetalen;
            Gratis = gratis;
        }

        public double BerekenPrijsPromo()
        {
            return Product.Prijs * TeBetalen;
        }

        public void ToonPromo()
        {
            var actieprijs_kg = Product.PrijsPerKg() * TeBetalen / (TeBetalen+Gratis);
            Console.WriteLine($"{Product.Naam}: {TeBetalen}+{Gratis} gratis! ({BerekenPrijsPromo()} i.p.v. {BerekenNormalePrijs()}. Actieprijs: {actieprijs_kg})");
        }

        public double BerekenNormalePrijs()
        {
            return Product.Prijs * (TeBetalen + Gratis);
        }

        public double BerekenKorting()
        {
            return BerekenNormalePrijs() - BerekenPrijsPromo();
        }
    }
}
