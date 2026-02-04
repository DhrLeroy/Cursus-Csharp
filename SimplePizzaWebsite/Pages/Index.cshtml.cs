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
            Bestellingen = new List<Bestelling>()
            {
                new Bestelling("Albert.Einstein@imsosmart.com", "Bergstraat 67 - 9000 Gent", 1, 2, 3),
                new Bestelling("Emmanuel_Kant@ithinkso.org", "Dorpwegel 1 - 1000 Brussel", 0, 1, 0)

            };
            //Pizzas = PizzaProvider.Pizzas();
        }

        public void OnPost()
        {
            Console.WriteLine();
        }
    }
}
