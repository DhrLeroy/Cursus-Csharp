using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_classes;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class EditModel : PageModel
    {
        private readonly MyMotorbikeStore_MySQL.MySQLDatabase _context;

        public EditModel(MyMotorbikeStore_MySQL.MySQLDatabase context)
        {
            _context = context;
        }

        [BindProperty]
        public Motorbike Motorbike { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorbike =  await _context.Motorbikes.FirstOrDefaultAsync(m => m.Id == id);
            if (motorbike == null)
            {
                return NotFound();
            }
            Motorbike = motorbike;
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

            _context.Attach(Motorbike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotorbikeExists(Motorbike.Id))
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

        private bool MotorbikeExists(int id)
        {
            return _context.Motorbikes.Any(e => e.Id == id);
        }
    }
}
