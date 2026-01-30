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
    public class DetailsModel : PageModel
    {
        private readonly IMotorbikeService motorbikeService;

        public DetailsModel(IMotorbikeService motorbikeService)
        {
            this.motorbikeService = motorbikeService;
        }

        public Motorbike Motorbike { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorbike = motorbikeService.GetMotorbikeById(id.Value);
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
