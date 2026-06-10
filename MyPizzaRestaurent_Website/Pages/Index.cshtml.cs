using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPizzaRestaurent_Website;
using PizzaInterfaces;
using PizzaKlassen;

namespace MyPizzaRestaurent_Website.Pages.PizzaPages;

public class IndexModel : PageModel
{
    private readonly IPizzaLogic pizzaLogic;

    public IndexModel(IPizzaLogic pizzaLogic)
    {
       this.pizzaLogic = pizzaLogic;
    }

    public IList<Pizza> Pizza { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Pizza = pizzaLogic.GeefAllePizzas();
    }
}
