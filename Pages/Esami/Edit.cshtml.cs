using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Esami
{
    public class EditModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public EditModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Esame Esame { get; set; }

        public SelectList NomiTipoAmbulatori; // Per prendere la lista dei nomi delle tipi di ambulatorio
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Esame = await _context.Esame.SingleOrDefaultAsync(m => m.EsameID == id);

            if (Esame == null)
            {
                return NotFound();
            }
            IQueryable<string> queryNomiTipoAmbulatori = from m in _context.TipoAmbulatorio
                                                         orderby m.NomeTipo
                                                         select m.NomeTipo;
            NomiTipoAmbulatori = new SelectList(await queryNomiTipoAmbulatori.ToListAsync());
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Esame).State = EntityState.Modified;

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
