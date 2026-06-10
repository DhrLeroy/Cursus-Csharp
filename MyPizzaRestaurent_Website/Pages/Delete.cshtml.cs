using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaKlassen;
using PizzaInterfaces;

namespace MyPizzaRestaurent_Website.Pages.PizzaPages;

public class DeleteModel : PageModel
{
    private readonly IPizzaLogic pizzaLogic;

    public DeleteModel(IPizzaLogic pizzaLogic)
    {
        this.pizzaLogic = pizzaLogic;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var pizza = pizzaLogic.GeefPizzaById(id);
        if (pizza != null)
        {
            pizzaLogic.VerwijderPizza(pizza);
        }

        return RedirectToPage("./Index");
    }
}
