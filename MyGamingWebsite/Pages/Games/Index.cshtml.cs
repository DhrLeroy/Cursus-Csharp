using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyGaming_Classes;
using MyGaming_MySQL;

namespace MyGamingWebsite.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly MyGaming_MySQL.MySQLDatabase _context;

        public IndexModel(MyGaming_MySQL.MySQLDatabase context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Games.ToListAsync();
        }
    }
}
