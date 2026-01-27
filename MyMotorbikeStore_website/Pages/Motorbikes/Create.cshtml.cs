using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_classes;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class CreateModel : PageModel
    {
        private readonly MyMotorbikeStore_MySQL.MySQLDatabase _context;

        public CreateModel(MyMotorbikeStore_MySQL.MySQLDatabase context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Motorbike Motorbike { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Motorbikes.Add(Motorbike);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
