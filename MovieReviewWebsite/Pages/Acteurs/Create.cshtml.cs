using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieReviewWebsite.Databank;
using MovieReviewWebsite.Klassen;

namespace MovieReviewWebsite.Pages.Acteurs
{
    public class CreateModel : PageModel
    {
        private readonly MovieReviewWebsite.Databank.MySQLConnectie _context;

        public CreateModel(MovieReviewWebsite.Databank.MySQLConnectie context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Acteur Acteur { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Acteurs.Add(Acteur);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
