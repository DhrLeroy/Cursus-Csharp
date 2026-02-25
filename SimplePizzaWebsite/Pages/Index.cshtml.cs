using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimplePizzaWebsite.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Bestelling> Bestellingen { get; set; }
        /*[BindProperty]
        public List<Pizza> Pizzas { get; set; }*/

        public void OnGet()
        {
            Bestellingen = new List<Bestelling>();
            //Pizzas = PizzaProvider.Pizzas();
        }

        public void OnPost()
        {
            Console.WriteLine();
        }
    }
}
