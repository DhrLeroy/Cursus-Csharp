using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace SimplePizzaWebsite.Pages
{
    public class IndexModel : PageModel
    {
        //Stap 4: maak een property (private) voor de databank
        private Databank db;

        //Stap 5: maak een constructor aan die een Databank-object meegeeft
        // Dit is de enigste constructor, dus deze wordt sowieso opgeroepen door ASP.NET Core
        public IndexModel(Databank db)
        {
            //Stap 6: stel de databank property in
            this.db = db;
        }

        //Stap 2: schrijf hier het attribuut BindProperty bij
        [BindProperty]
        //Stap 1: maak een property aan om op de webpagina te overlopen/uit te lezen
        public List<Bestelling> Bestellingen { get; set; }

        //Stap 3: Maak een OnGet methode aan
        public void OnGet()
        {
            //Stap 7: haal alle bestellingen op uit de databank
            Bestellingen = db.Bestellingen
                .Include(b => b.Bestellijnen)
                .ThenInclude(b => b.Pizza)
                .ToList();
        }
    }
}
