using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeries_Db
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string Naam { get; set; }
        public string Beschrijving {  get; set; }
        public List<Seizoen> Seizoenen {  get; set; } = new List<Seizoen>();
    }

    public class Seizoen
    {
        public int SeizoenId { get; set; }
        public int Volgnummer { get; set; }
        public List<Aflevering> Afleveringen { get; set; } = new List<Aflevering>();
    }

    public class Aflevering
    {
        public int AfleveringId { get; set; }
        public string Titel { get; set; }
        public float Rating { get; set; }
    }
}
