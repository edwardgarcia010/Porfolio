using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Econass.Pages
{
    public class ContactOptionsModel : PageModel
    {
        [BindProperty]
      

        public bool MessageSent { get; set; } = false;

        public void OnGet()
        {
            MessageSent = false;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            MessageSent = true;

            return Page();
        }
    }
}
    
