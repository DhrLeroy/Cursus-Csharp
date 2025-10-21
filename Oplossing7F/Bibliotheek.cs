using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7F
{
    public class Bibliotheek
    {
        public List<Boek> Boeken { get; set; } = new List<Boek>();
        public string Adres { get; set; }
        public string Medewerker { get; set; }
        public bool Geopend { get; set; }

        public Bibliotheek(string adres, string medewerker, bool geopend)
        {
            Adres = adres;
            Medewerker = medewerker;
            Geopend = geopend;
        }

        public Boek Ontleen(string titel, string auteur)
        {
            if (!Geopend)
            {
                return null;
            }
            foreach (var boek in Boeken)
            {
                if (boek.Titel.Equals(titel, StringComparison.CurrentCultureIgnoreCase) 
                    && boek.Auteur.Equals(auteur, StringComparison.CurrentCultureIgnoreCase)
                    && !boek.Uitgeleend)
                {
                    boek.Uitgeleend = true;
                    return boek;
                }
            }
            return null;
        }

        public void VoegBoekToe(string titel, string auteur, int aantal_paginas, string genre)
        {
            Boeken.Add(new Boek(titel, auteur, aantal_paginas, genre));
        }

        public bool VerwijderBoek(string titel, string auteur)
        {
            foreach (var boek in Boeken)
            {
                if (boek.Titel.Equals(titel, StringComparison.CurrentCultureIgnoreCase)
                    && boek.Auteur.Equals(auteur, StringComparison.CurrentCultureIgnoreCase))
                {
                    Boeken.Remove(boek);
                    return true;
                }
            }
            return false;
        }
    }

    public class Boek
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public int Aantal_paginas { get; set; }
        public string Genre { get; set; }
        public bool Uitgeleend { get; set; } = false;

        public Boek(string titel, string auteur, int aantal_paginas, string genre)
        {
            Titel = titel;
            Auteur = auteur;
            Aantal_paginas = aantal_paginas;
            Genre = genre;
        }


    }

}
