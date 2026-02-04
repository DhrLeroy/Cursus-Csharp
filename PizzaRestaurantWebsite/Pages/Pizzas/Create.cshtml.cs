using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaRestaurantWebsite.Databank;
using PizzaRestaurantWebsite.Klassen;

namespace PizzaRestaurantWebsite.Pages.Pizzas
{
    public class CreateModel : PageModel
    {
        private readonly PizzaRestaurantWebsite.Databank.MySQLDatabank _context;

        public CreateModel(PizzaRestaurantWebsite.Databank.MySQLDatabank context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pizzas.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
