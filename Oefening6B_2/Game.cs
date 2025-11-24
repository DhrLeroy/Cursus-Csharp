//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6B_2
{
    public class Game
    {
        public string Titel { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duur { get; set; }
        public DateTime Releasedatum { get; set; }
        public string Platform { get; set; }
        public double Beoordeling { get; set; }
        public string Franchise { get; set; }
        public List<string> Talen { get; set; } = new();
        public List<Personage> Personages { get; set; } = new();
        public List<Achievement> Achievements { get; set; } = new(); // Nieuw

        public Game(string titel, string genre, TimeSpan duur, DateTime releasedatum, string platform, double beoordeling, string franchise, IEnumerable<string> talen)
        {
            Titel = titel;
            Genre = genre;
            Duur = duur;
            Releasedatum = releasedatum;
            Platform = platform;
            Beoordeling = beoordeling;
            Franchise = franchise;
            Talen = talen.ToList();
        }

        public void VoegPersonageToe(Personage p)
        {
            Personages.Add(p);
        }

        public void VoegAchievementToe(Achievement a)
        {
            Achievements.Add(a);
        }
        public override string? ToString()
        {
            return Titel;
        }
    }
}
