using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaRestaurantWebsite.Databank;
using PizzaRestaurantWebsite.Klassen;

namespace PizzaRestaurantWebsite.Pages.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly PizzaRestaurantWebsite.Databank.MySQLDatabank _context;

        public DetailsModel(PizzaRestaurantWebsite.Databank.MySQLDatabank context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            else
            {
                Pizza = pizza;
            }
            return Page();
        }
    }
}
