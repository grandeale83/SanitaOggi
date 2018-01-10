using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SanitaOggi.Models;
using Microsoft.EntityFrameworkCore;

namespace SanitaOggi.Pages.Ambulatori
{
    public class CreateModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public CreateModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        /*
         * Questo metodo va a sostituire l'OnGet() semplice
         * perché nel caricare la pagina bisogna caricare
         * la lista deei nomi delle strutture e dei tipi di ambulatorio
         */
        public SelectList NomiStrutture; // Per prendere la lista dei nomi delle strutture
        public SelectList NomiTipoAmbulatori; // Per prendere la lista dei nomi delle tipi di ambulatorio
        public async Task OnGetAsync()
        {
            /*
             * Non si riesce a caricare sia per le strutture che per
             * i tipi di ambulatorio l'abbinamento tra chiave-codice
             * e nome, in modo da usarli nella dropdownlist (tag select)
             * come valore e testo. L'obbiettivo sarebbe stato di usare 
             * il nome nella view, ma la chiave-codice nel db.
             */
            IQueryable<string> queryNomiStrutture = from m in _context.Struttura
                                                    orderby m.NomeStruttura
                                                    select m.NomeStruttura;
            NomiStrutture = new SelectList(await queryNomiStrutture.ToListAsync());
            IQueryable<string> queryNomiTipoAmbulatori = from m in _context.TipoAmbulatorio
                                                      select m.NomeTipo;
            NomiTipoAmbulatori = new SelectList(await queryNomiTipoAmbulatori.ToListAsync());
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