using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_classes;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class DetailsModel : PageModel
    {
        private readonly MyMotorbikeStore_MySQL.MySQLDatabase _context;

        public DetailsModel(MyMotorbikeStore_MySQL.MySQLDatabase context)
        {
            _context = context;
        }

        public Motorbike Motorbike { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorbike = await _context.Motorbikes.FirstOrDefaultAsync(m => m.Id == id);
            if (motorbike == null)
            {
                return NotFound();
            }
            else
            {
                Motorbike = motorbike;
            }
            return Page();
        }
    }
}
