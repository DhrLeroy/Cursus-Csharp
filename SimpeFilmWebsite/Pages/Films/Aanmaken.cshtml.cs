using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpeFilmWebsite.Klassen;

namespace SimpeFilmWebsite.Pages.Films
{
    public class AanmakenModel : PageModel
    {
        private Databank db;

        public AanmakenModel(Databank db)
        {
            this.db = db;
        }

        [BindProperty]
        public Film Film { get; set; }

        public void OnGet()
        {
            Film = new Film();
        }

        public void OnPost() {
            db.Films.Add(Film);
            db.SaveChanges();
        }
    }
}
