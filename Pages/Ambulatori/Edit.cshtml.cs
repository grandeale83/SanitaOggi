using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Ambulatori
{
    public class EditModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public EditModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ambulatorio Ambulatorio { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ambulatorio = await _context.Ambulatorio.SingleOrDefaultAsync(m => m.AmbulatorioID == id);

            if (Ambulatorio == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ambulatorio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
