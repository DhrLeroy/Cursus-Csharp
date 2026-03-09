using EersteWebsite_Databank;
using Klassen_EersteWebsite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EersteWebsite.Pages
{
    public class DetailModel : PageModel
    {
        public Videogame Game { get; set; }
        public void OnGet(int id)
        {
            var db = new Connectie();
            //Game = db.Videogames.First(v => v.Id == id);
            //Game = db.Videogames.Single(v => v.Id == id);
            Game = db.Videogames.Find(id);
        }
    }
}
