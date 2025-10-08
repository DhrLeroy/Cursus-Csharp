using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7D
{
    public class IJskraam
    {
        public int Vanille { get; set; }
        public int Choco { get; set; }
        public int Aardbei { get; set; }
        public float Kassa { get; set; }

        public IJskraam(float kassa)
        {
            Kassa = kassa;
            Vanille = 20;
            Choco = 20;
            Aardbei = 20;
        }

        public float Bestel(int vanille, int choco, int aardbei, bool potje, float bedrag)
        {
            if (Vanille < vanille || Choco < choco || Aardbei < aardbei)
            {
                Console.WriteLine("Er zijn niet genoeg bollen voor deze bestelling.");
                return bedrag;
            }

            var aantal_bollen = vanille + choco + aardbei;
            float prijs = (aantal_bollen / 3) * 5.5f;
            aantal_bollen -= (aantal_bollen / 3) * 3;
            prijs += (aantal_bollen / 2) * 4f;
            aantal_bollen -= (aantal_bollen / 2) * 2;
            prijs += aantal_bollen * 2.5f;

            /*if (potje)
            {
                prijs += 0.5f;
            }*/

            //of

            prijs += potje ? 0.5f : 0f;

            if(prijs > bedrag)
            {
                var te_weinig = prijs - bedrag;
                Console.WriteLine($"Je hebt {te_weinig} euro te weinig.");
                return bedrag;
            }
            else
            {
                var wisselgeld = bedrag - prijs;

                if(wisselgeld <= Kassa)
                {
                    Console.WriteLine($"Je krijgt {wisselgeld} terug.");
                    Kassa -= wisselgeld;
                    Vanille -= vanille;
                    Choco -= choco;
                    Aardbei -= aardbei;
                    return wisselgeld;
                }
                else
                {
                    Console.WriteLine("Verkoop kon niet doorgaan wegens te weinig wisselgeld in kassa.");
                    return bedrag;
                }

            }
        }
    }
}
