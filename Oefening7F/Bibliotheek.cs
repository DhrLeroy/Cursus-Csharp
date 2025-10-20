using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7F
{
    public class Bibliotheek
    {
        private bool heeftDvds;

        public bool HeeftDvds
        {
            get { return heeftDvds; }
            set { 
                if(heeftDvds==false)
                    heeftDvds = value; 
            }
        }

        public readonly int AantalSpelletjes;

        private List<Boek> Boeken { get; set; } = new List<Boek>();
        private string Adres { get; set; }
        public string Medewerker { get; set; }
        private bool Geopend { get; set; }

        private int aantalDvds;

        public int AantalDvds
        {
            get { return aantalDvds; }
            set { 
                if(value >= 0)  
                    aantalDvds = value;
             }
        }


        public Bibliotheek(string adres)
        {
            Adres = adres;
            HeeftDvds = false;
        }

        public Bibliotheek(string adres, string medewerker) : this(adres)
        {
            Medewerker = medewerker;
            AantalSpelletjes = 10;
        }

        public void VoegBoekToe(string titel, string auteur, int aantal_paginas, string genre)
        {
            AantalSpelletjes = 0;
        }

        public Boek LeenUit(string titel, string auteur)
        {
            if (!Geopend)
            {
                return null;
            }
            return null;
        }

        public string GeefAdres()
        {
            return Adres;
        }

        public void StelAdresIn(string adres)
        {
            if(adres.IndexOf("-") > 0 && adres.LastIndexOf("-") < adres.Length-5)
                Adres = adres;
        }
    }

    public class Dvd
    {

    }
}
