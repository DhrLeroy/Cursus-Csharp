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
    public class IndexModel : PageModel
    {
        private readonly MovieReviewWebsite.Databank.MySQLConnectie _context;

        public IndexModel(MovieReviewWebsite.Databank.MySQLConnectie context)
        {
            _context = context;
        }

        public IList<Acteur> Acteur { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Acteur = await _context.Acteurs.ToListAsync();
        }
    }
}
