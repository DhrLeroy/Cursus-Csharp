using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimplePizzaWebsite.Pages
{
    public class BestellingModel : PageModel
    {
        private Databank db;

        public BestellingModel(Databank db)
        {
            this.db = db;
        }

        [BindProperty]
        public Bestelling Bestelling { get; set; }
        public void OnGet()
        {
            Bestelling = new Bestelling();
            foreach(var pizza in db.Pizzas)
            {
                var bestellijn = new Bestellijn();
                bestellijn.Pizza = pizza;
                Bestelling.Bestellijnen.Add(bestellijn);
            }
        }

        public void OnPost()
        {
            Bestelling.Bestellijnen.RemoveAll(b => b.Aantal == 0);

            /* Lange versie van lijn hierboven
            var bestellijnen_aantal0 = Bestelling.Bestellijnen.Where(b => b.Aantal == 0).ToList();
            foreach(var bestellijn in bestellijnen_aantal0)
            {
                Bestelling.Bestellijnen.Remove(bestellijn);
            }*/

            // We moeten de pizza's opnieuw ophalen van de databank, want anders probeert EF Core nieuwe pizza's aan te maken in plaats van de bestaande te gebruiken
            foreach (var bestellijn in Bestelling.Bestellijnen)
            {
                bestellijn.Pizza = db.Pizzas.First(p => p.Id == bestellijn.Pizza.Id);
            }

            Bestelling.Datum = DateTime.Now;

            db.Bestellingen.Add(Bestelling);
            db.SaveChanges();
        }
    }

}
