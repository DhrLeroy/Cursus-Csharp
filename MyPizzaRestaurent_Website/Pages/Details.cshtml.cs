using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPizzaRestaurent_Website;
using PizzaInterfaces;
using PizzaKlassen;

namespace MyPizzaRestaurent_Website.Pages.PizzaPages;

public class DetailsModel : PageModel
{
    private readonly IPizzaLogic pizzaLogic;

    public DetailsModel(IPizzaLogic pizzaLogic)
    {
        this.pizzaLogic = pizzaLogic;
    }

    public Pizza Pizza { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var pizza = pizzaLogic.GeefPizzaById(id);
        if (pizza is null)
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
