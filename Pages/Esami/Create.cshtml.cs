using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SanitaOggi.Models;
using Microsoft.EntityFrameworkCore;

namespace SanitaOggi.Pages.Esami
{
    public class CreateModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public CreateModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public SelectList NomiTipoAmbulatori; // Per prendere la lista dei nomi delle tipi di ambulatorio
        public async Task OnGetAsync()
        {
            IQueryable<string> queryNomiTipoAmbulatori = from m in _context.TipoAmbulatorio
                                                         orderby m.NomeTipo
                                                         select m.NomeTipo;
            NomiTipoAmbulatori = new SelectList(await queryNomiTipoAmbulatori.ToListAsync());
        }

        [BindProperty]
        public Esame Esame { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Esame.Add(Esame);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}