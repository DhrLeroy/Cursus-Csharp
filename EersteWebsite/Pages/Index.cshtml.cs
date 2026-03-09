using EersteWebsite_Databank;
using Klassen_EersteWebsite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EersteWebsite.Pages
{
    public class IndexModel : PageModel
    {
        public List<Videogame> Videogames { get; set; }
        public void OnGet()
        {
            var db = new Connectie();
            Videogames = db.Videogames.ToList();
        }
    }
}
