using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_examen_2_5ICW___2045_2025___Oefening_1
{
    public abstract class Kaart
    {
        public string Naam { get; set; }
        public int Jaartal { get; set; }
        public string Illustrator { get; set; }
        public string NaamSet { get; set; }
        public int NummerInSet { get; set; }
        public string Omschrijving { get; set; }


        protected Kaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving)
        {
            Naam = naam;
            Jaartal = jaartal;
            Illustrator = illustrator;
            NaamSet = naamSet;
            NummerInSet = nummerInSet;
            Omschrijving = omschrijving;
        }
    }
    public abstract class Pokemonkaart : Kaart
    {


        protected Pokemonkaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, int totaalinset) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving)
        {
            TotaalInSet = totaalinset;
        }

        public int TotaalInSet { get; set; }



    }

    public enum EnergyType
    {
        Elektric,
        Metal,
        Water,
        Normal,
        Fighting,
        Fire,
        Psychic
    }

    public class PokemonMonsterkaart : Pokemonkaart
    {
        public PokemonMonsterkaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, 
            string omschrijving, int totaalinset, string prevolutie, int hP, EnergyType type, params Pokemonaanval[] aanvallen) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving, totaalinset)
        {
            Prevolutie = prevolutie;
            HP = hP;
            Type = type;
            Aanvallen = aanvallen.ToList();
        }


        public string Prevolutie { get; set; }
        public int HP { get; set; }
        public EnergyType Type { get; set; }
        public List<Pokemonaanval> Aanvallen { get; set; }
    }

    public class Pokemonaanval
    {
        public string Naam { get; set; }
        public int Schade { get; set; }
        public List<EnergyType> EnergieKosten { get; set; }
        public string Omschrijving { get; set; }

        public Pokemonaanval(string naam, int schade, string omschrijving, params EnergyType[] energieKosten)
        {
            Naam = naam;
            Schade = schade;
            EnergieKosten = energieKosten.ToList();
            Omschrijving = omschrijving;
        }
    }

    public class Energykaart : Pokemonkaart
    {
        public Energykaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, int totaalinset) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving, totaalinset)
        {
        }

        public EnergyType Type { get; set; }
    }

    public class Trainerkaart : Pokemonkaart
    {
        public Trainerkaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, int totaalinset) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving, totaalinset)
        {
        }
    }

    public abstract class Yugiohkaart : Kaart
    {
        protected Yugiohkaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, string edition, string nummer) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving)
        {
            Edition = edition;
            Nummer = nummer;
        }

        public string Edition { get; set; }
        public string Nummer { get; set; }


    }

    public class YugiohMonsterkaart : Yugiohkaart
    {
        public YugiohMonsterkaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, string edition, string nummer, int sterren, int aTK, int dEF) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving, edition, nummer)
        {
            Sterren = sterren;
            ATK = aTK;
            DEF = dEF;
        }

        public int Sterren { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
    }

    public class SpellTrapKaart : Yugiohkaart
    {
        public SpellTrapKaart(string naam, int jaartal, string illustrator, string naamSet, int nummerInSet, string omschrijving, string edition, string nummer) : base(naam, jaartal, illustrator, naamSet, nummerInSet, omschrijving, edition, nummer)
        {
        }
    }
}
