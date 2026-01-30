using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_classes;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class IndexModel : PageModel
    {
        private readonly IMotorbikeService motorbikeService;

        public IndexModel(IMotorbikeService motorbikeService)
        {
            this.motorbikeService = motorbikeService;
        }

        public IList<Motorbike> Motorbike { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Motorbike = motorbikeService.GetAllMotorbikes();
        }
    }
}
