using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieReviewWebsite.Databank;
using MovieReviewWebsite.Klassen;

namespace MovieReviewWebsite.Pages.Acteurs
{
    public class EditModel : PageModel
    {
        private readonly MovieReviewWebsite.Databank.MySQLConnectie _context;

        public EditModel(MovieReviewWebsite.Databank.MySQLConnectie context)
        {
            _context = context;
        }

        [BindProperty]
        public Acteur Acteur { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acteur =  await _context.Acteurs.FirstOrDefaultAsync(m => m.Id == id);
            if (acteur == null)
            {
                return NotFound();
            }
            Acteur = acteur;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Acteur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActeurExists(Acteur.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ActeurExists(int id)
        {
            return _context.Acteurs.Any(e => e.Id == id);
        }
    }
}
