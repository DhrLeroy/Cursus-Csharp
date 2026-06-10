using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPizzaRestaurent_Website;
using PizzaInterfaces;
using PizzaKlassen;

namespace MyPizzaRestaurent_Website.Pages.PizzaPages;

public class EditModel : PageModel
{
    private readonly IPizzaLogic pizzaLogic;

    public EditModel(IPizzaLogic pizzaLogic)
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
        Pizza = pizza;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        

        try
        {
            pizzaLogic.UpdatePizza(Pizza);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PizzaExists(Pizza.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool PizzaExists(int id)
    {
        return pizzaLogic.BestaatPizzaMetId(id);
    }
}
