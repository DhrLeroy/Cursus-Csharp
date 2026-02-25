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
            db.Bestellingen.Add(Bestelling);
            db.SaveChanges();
        }
    }

}
