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
    public class IndexModel : PageModel
    {
        private readonly MyMotorbikeStore_MySQL.MySQLDatabase _context;

        public IndexModel(MyMotorbikeStore_MySQL.MySQLDatabase context)
        {
            _context = context;
        }

        public IList<Motorbike> Motorbike { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Motorbike = await _context.Motorbikes.ToListAsync();
        }
    }
}
