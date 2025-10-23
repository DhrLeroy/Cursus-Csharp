using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7H
{
    public class Drankautomaat
    {
        public string[] Dranken { get; set; }
        public int[] AantalDranken { get; set; }
        public int[] AantalMunten { get; set; }
        public float[] Muntwaardes = new float[] { 0.01f, 0.02f, 0.05f, 0.10f, 0.20f, 0.50f, 1f, 2f};

        public int MaxBlikjes { get; set; }

        public Drankautomaat(int aantalDranken, int maxBlikjesPerDrank, params int[] aantalMunten)
        {
            AantalDranken = new int[aantalDranken];
            MaxBlikjes = maxBlikjesPerDrank;
            AantalMunten = aantalMunten;
        }

        public int VulAan(string drank, int aantal)
        {
            for (int i = 0; i < Dranken.Length; i++)
            {
                if (Dranken[i].Equals(drank, StringComparison.CurrentCultureIgnoreCase))
                {
                    int beschikbaar = MaxBlikjes - AantalDranken[i];
                    int toeTeVoegen = Math.Min(beschikbaar, aantal);
                    AantalDranken[i] += toeTeVoegen;
                    return aantal - toeTeVoegen;
                }
            }
            for (int i = 0; i < Dranken.Length; i++)
            {
                if (Dranken[i]=="")
                {
                    int toeTeVoegen = Math.Min(MaxBlikjes, aantal);
                    AantalDranken[i] += toeTeVoegen;
                    return aantal - toeTeVoegen;
                }
            }
            for (int i = 0; i < Dranken.Length; i++)
            {
                if (AantalDranken[i] == 0)
                {
                    int toeTeVoegen = Math.Min(MaxBlikjes, aantal);
                    AantalDranken[i] += toeTeVoegen;
                    return aantal - toeTeVoegen;
                }
            }
            return aantal;
        }

        public int[] KoopDrank(string drank, params int[] munten)
        {
            float bedrag = 0f;
            //ingegeven bedrag bepalen
            for(int i = 0; i < munten.Length; i++)
            {
                bedrag += munten[i] * Muntwaardes[i];
            }

            //als bedrag niet 1.3 euro is (prijs drank): geld teruggeven
            if (bedrag < 1.3f)
                return munten;

            //drank zoeken
            for (int i = 0; i < Dranken.Length; i++)
            {
                //kijk of drank gevonden werd en er nog blikjes zijn
                if (Dranken[i].Equals(drank, StringComparison.CurrentCultureIgnoreCase) 
                    && AantalDranken[i] > 0)
                {
                    //ingegeven geld bij wisselgeld steken
                    for(int j = 0; j < munten.Length; j++)
                    {
                        AantalMunten[j] += munten[j];
                        munten[j] = 0;
                    }
                    //aantal blikjes met 1 verminderen
                    AantalDranken[i]--;

                    //bedrag wisselgeld berekenen
                    var bedragTerug = bedrag - 1.3f;
                    //wisselgeld munten berekenen
                    for(int j = Muntwaardes.Length-1; j >= 0; j--)
                    {
                        int gewensteAantalMunten = Convert.ToInt32((bedragTerug - (bedragTerug % Muntwaardes[j])) / Muntwaardes[j]);
                        int aantalMuntenTerug = Math.Min(AantalMunten[j], gewensteAantalMunten);
                        AantalMunten[j] -= aantalMuntenTerug;
                        munten[j] = aantalMuntenTerug;
                        bedrag -= aantalMuntenTerug * Muntwaardes[j];
                    }
                    return munten;
                }
            }
            return munten;
        }



    }
}
