using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Econass.Pages
{
    public class HireMeModel : PageModel
    {

        [BindProperty]
        public bool AgreeToTerms { get; set; }

        public bool FormSubmitted { get; set; } = false;

        public void OnGet()
        {
            FormSubmitted = false;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            FormSubmitted = true;
            return Page();
        }
    }
}


