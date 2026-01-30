using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyMotorbikeStore_MySQL;
using MyMotorbikeStore_classes;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class CreateModel : PageModel
    {
        private readonly IMotorbikeService motorbikeService;

        public CreateModel(IMotorbikeService motorbikeService)
        {
            this.motorbikeService = motorbikeService;
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

            motorbikeService.AddMotorbike(Motorbike);

            return RedirectToPage("./Index");
        }
    }
}
