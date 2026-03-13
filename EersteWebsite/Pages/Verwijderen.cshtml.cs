using EersteWebsite_Databank;
using Klassen_EersteWebsite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EersteWebsite.Pages
{
    public class VerwijderenModel : PageModel
    {
        [BindProperty]
        public Videogame Game { get; set; }
        public void OnGet(int id)
        {
            var db = new Connectie();
            Game = db.Videogames.Find(id);
        }

        [BindProperty]
        public Test Test { get; set; }

        public IActionResult OnPost() { 
            var db = new Connectie();
            db.Videogames.Remove(Game);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
