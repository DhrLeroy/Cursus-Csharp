using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_website.Pages
{
    public class IndexModel : PageModel
    {
        public IMotorbikeService _motorbikeService;

        public IndexModel(IMotorbikeService service)
        {
            _motorbikeService = service;
        }

        public void OnGet()
        {
            
        }
    }
}
