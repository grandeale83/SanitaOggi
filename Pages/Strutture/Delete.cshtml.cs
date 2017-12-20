using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Strutture
{
    public class DeleteModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public DeleteModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Struttura Struttura { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Struttura = await _context.Struttura.SingleOrDefaultAsync(m => m.StrutturaID == id);

            if (Struttura == null)
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

            Struttura = await _context.Struttura.FindAsync(id);

            if (Struttura != null)
            {
                _context.Struttura.Remove(Struttura);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
