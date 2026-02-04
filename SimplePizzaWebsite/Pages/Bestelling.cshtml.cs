using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimplePizzaWebsite.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public Bestelling Bestelling { get; set; }
        public void OnGet()
        {
            Bestelling = new Bestelling();
        }
    }

}
