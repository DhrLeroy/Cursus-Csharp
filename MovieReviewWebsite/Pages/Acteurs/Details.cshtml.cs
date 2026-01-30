using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviewWebsite.Databank;
using MovieReviewWebsite.Klassen;

namespace MovieReviewWebsite.Pages.Acteurs
{
    public class DetailsModel : PageModel
    {
        private readonly MovieReviewWebsite.Databank.MySQLConnectie _context;

        public DetailsModel(MovieReviewWebsite.Databank.MySQLConnectie context)
        {
            _context = context;
        }

        public Acteur Acteur { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acteur = await _context.Acteurs.FirstOrDefaultAsync(m => m.Id == id);
            if (acteur == null)
            {
                return NotFound();
            }
            else
            {
                Acteur = acteur;
            }
            return Page();
        }
    }
}
