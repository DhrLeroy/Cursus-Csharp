using EersteWebsite_Databank;
using Klassen_EersteWebsite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EersteWebsite.Pages
{
    [BindProperties]
    public class AanmakenModel : PageModel
    {
        public string Naam { get; set; }
        public Videogame Game {  get; set; }
        public void OnGet()
        {
            Game = new Videogame();
        }
        public IActionResult OnPost()
        {
            var db = new Connectie();
            db.Videogames.Add(Game);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
