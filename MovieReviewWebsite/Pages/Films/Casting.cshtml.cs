using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviewWebsite.Databank;
using MovieReviewWebsite.Klassen;

namespace MovieReviewWebsite.Pages.Films
{
    public class CastingModel : PageModel
    {
        private MySQLConnectie db;
        public CastingModel(MySQLConnectie db)
        {
            this.db = db;
        }

        [BindProperty]
        public Film Film { get; set; }

        [BindProperty]
        public List<Cast> Casting { get; set; }


        public void OnGet(int id)
        {
            Film = db.Films.Include(f => f.Cast).ThenInclude(c => c.Acteur).First(f => f.Id == id);

            Casting = Film.Cast.ToList();

            foreach(var acteur in db.Acteurs)
            {
                if(!Casting.Any(c => c.Acteur == acteur))
                {
                    Casting.Add(new Cast()
                    {
                        Acteur = acteur,
                        Film = Film,
                        Rol = ""
                    });
                }
            }
            Console.WriteLine("");
        }

        public IActionResult OnPost()
        {
            var film = db.Films.Include(f => f.Cast).First(f => f.Id == Film.Id);

            foreach (var cast in Casting)
            {
                if (cast.Id != 0)
                {
                    var c = film.Cast.First(c => c.Id == cast.Id);
                    if (cast.Rol == "")
                    {
                        film.Cast.Remove(c);
                    }
                    else
                    {
                        c.Rol = cast.Rol;
                    }
                }
                else if (!string.IsNullOrEmpty(cast.Rol))
                {
                    var acteur = db.Acteurs.First(a => a.Id == cast.Acteur.Id);
                    cast.Acteur = acteur;
                    film.Cast.Add(cast);
                }
            }
            var changes = db.SaveChanges();
            Console.WriteLine("");

            return RedirectToPage("Index");
        }
    }
}
