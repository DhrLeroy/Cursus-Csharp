using EersteWebsite_Databank;
using Klassen_EersteWebsite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EersteWebsite.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Videogame> Videogames { get; set; }
        public void OnGet()
        {
            var db = new Connectie();
            Videogames = db.Videogames.ToList();
        }

        public void OnPost()
        {
            var db = new Connectie();
            foreach (var g in Videogames) {
                var game_db = db.Videogames.Find(g.Id);
                game_db.Titel = g.Titel;
            }
            db.SaveChanges();
        }
    }
}
