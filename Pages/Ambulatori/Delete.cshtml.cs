using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Ambulatori
{
    public class DeleteModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public DeleteModel(SanitaOggi.Models.SanitaContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ambulatorio = await _context.Ambulatorio.FindAsync(id);

            if (Ambulatorio != null)
            {
                _context.Ambulatorio.Remove(Ambulatorio);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
