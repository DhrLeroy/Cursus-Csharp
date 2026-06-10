using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPizzaRestaurent_Website;
using PizzaInterfaces;
using PizzaKlassen;

namespace MyPizzaRestaurent_Website.Pages.PizzaPages;

public class CreateModel : PageModel
{
    private readonly IPizzaLogic pizzaLogic;

    public CreateModel(IPizzaLogic pizzaLogic)
    {
        this.pizzaLogic = pizzaLogic;
    }
    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Pizza Pizza { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        pizzaLogic.VoegPizzaToe(Pizza);

        return RedirectToPage("./Index");
    }
}
