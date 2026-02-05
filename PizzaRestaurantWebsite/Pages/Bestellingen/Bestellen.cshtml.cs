using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRestaurantWebsite.Klassen;

namespace PizzaRestaurantWebsite.Pages.Bestellingen
{
    public class BestellenModel : PageModel
    {
        [BindProperty]
        public BestellingView Bestelling { get; set; }
        public void OnGet()
        {
            Bestelling = new BestellingView();
        }

        public void OnPost() {
            Console.WriteLine();
        }
    }

    

    public class BestellingView
    {
        public int Aantal_Margherita { get; set; }
        public int Aantal_Hawaii { get; set; }
    }
}
