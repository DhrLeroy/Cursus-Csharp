using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpeFilmWebsite.Klassen;

namespace SimpeFilmWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private Databank db;
        public IndexModel(Databank db)
        {
            this.db = db;
        }

        public List<Film> Films { get; set; }

        public void OnGet()
        {
            Films = db.Films.ToList();
        }
    }
}
