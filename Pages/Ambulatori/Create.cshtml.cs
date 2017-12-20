using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Ambulatori
{
    public class CreateModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;
        public List<SelectListItem> ListaStrutture { get; set; }

        public CreateModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ambulatorio Ambulatorio { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ambulatorio.Add(Ambulatorio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}