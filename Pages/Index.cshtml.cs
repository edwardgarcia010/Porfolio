using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Econass.Pages
{
    public class IndexModel : PageModel
    {
        public class ContactForm
        {
            [Required, StringLength(100)]
            public string Name { get; set; } = string.Empty;

            [Required, EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required, StringLength(1000)]
            public string Message { get; set; } = string.Empty;
        }

        [BindProperty]
        public ContactForm Form { get; set; } = new ContactForm();

        public bool Sent { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Sent = false;
                return Page();
            }


            Sent = true;


            ModelState.Clear();
            Form = new ContactForm();

            return Page();
        }
    }
}
