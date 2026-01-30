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
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_website.Pages.Motorbikes
{
    public class EditModel : PageModel
    {
        private readonly IMotorbikeService motorbikeService;

        public EditModel(IMotorbikeService motorbikeService)
        {
            this.motorbikeService = motorbikeService;
        }

        [BindProperty]
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

        

            try
            {
                motorbikeService.SaveMotorbike(Motorbike);
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
            try
            {
                motorbikeService.GetMotorbikeById(id);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
