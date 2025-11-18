using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziekinstrumenten
{
    public class Product
    {
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public string Fabrikant { get; set; }

        public Product(string naam, float prijs, string fabrikant)
        {
            Naam = naam;
            Prijs = prijs;
            Fabrikant = fabrikant;
        }
    }

    public class VoorInstrument : Product
    {
        public VoorInstrument(string naam, float prijs, string fabrikant,params Instrument[] instrumenten) : base(naam, prijs, fabrikant)
        {
            Instrumenten = instrumenten.ToList();
        }

        public List<Instrument> Instrumenten { get; set; }
    }

    public class Muziekboek : VoorInstrument
    {
        public Muziekboek(string auteur, int aantal_bladzijden, string niveau, string naam, float prijs, string fabrikant, params Instrument[] instrumenten) : base(naam, prijs, fabrikant, instrumenten)
        {
            Auteur = auteur;
            Aantal_bladzijden = aantal_bladzijden;
            Niveau = niveau;
        }

        //Fabrikant is Uitgeverij
        public string Auteur { get; set; }
        public int Aantal_bladzijden { get; set; }
        public string Niveau { get; set; }


    }

    public class Accesoire : VoorInstrument
    {
        public Accesoire(string naam, float prijs, string fabrikant, params Instrument[] instrumenten) : base(naam, prijs, fabrikant, instrumenten)
        {
        }
    }
    public class Instrument : Product
    {
        public Instrument(string naam, float prijs, string fabrikant) : base(naam, prijs, fabrikant)
        {
        }
    }
    public class KinderInstrument : Instrument {
        public KinderInstrument(string naam, float prijs, string fabrikant, bool kindermodel) : base(naam, prijs, fabrikant)
        {
            Kindermodel = kindermodel;
        }

        public bool Kindermodel { get; set; }


    }

    public class Gitaar : KinderInstrument
    {
        public Gitaar(string naam, float prijs, string fabrikant, bool kindermodel, string type_snaren) : base(naam, prijs, fabrikant, kindermodel)
        {
            Type_snaren = type_snaren;
        }

        public string Type_snaren {  get; set; }

    }
    public class Basgitaar : Gitaar
    {
        public Basgitaar(string naam, float prijs, string fabrikant, bool kindermodel, string type_snaren, string materiaal, bool fretloos) : base(naam, prijs, fabrikant, kindermodel, type_snaren)
        {
            Materiaal = materiaal;
            Fretloos = fretloos;
        }

        public string Materiaal { get; set; }
        public bool Fretloos { get; set; }

    }
    public class Elektrische_Gitaar : Gitaar
    {
        public Elektrische_Gitaar(string naam, float prijs, string fabrikant, bool kindermodel, string type_snaren, int aantal_Pickups, bool heeftWhammybar) : base(naam, prijs, fabrikant, kindermodel, type_snaren)
        {
            Aantal_Pickups = aantal_Pickups;
            HeeftWhammybar = heeftWhammybar;
        }

        public int Aantal_Pickups { get; set; }
        public bool HeeftWhammybar { get; set; }
    }
    public class Viool : KinderInstrument
    {
        public Viool(string naam, float prijs, string fabrikant, bool kindermodel, int bouwjaar, string materiaal, int aantal_snaren, bool altviool) : base(naam, prijs, fabrikant, kindermodel)
        {
            Bouwjaar = bouwjaar;
            Materiaal = materiaal;
            Aantal_snaren = aantal_snaren;
            Altviool = altviool;
        }

        public int Bouwjaar { get; set; }
        public string Materiaal { get; set; }
        public int Aantal_snaren { get; set; }
        public bool Altviool { get; set; }
    }
    public class Dwarsfluit : Instrument
    {
        public Dwarsfluit(string naam, float prijs, string fabrikant, int bouwjaar, string legering) : base(naam, prijs, fabrikant)
        {
            Bouwjaar = bouwjaar;
            Legering = legering;
        }

        public int Bouwjaar { get; set; }
        public string Legering { get; set; }
    }
}
