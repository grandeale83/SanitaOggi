using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.TipologiaAmbulatorio
{
    public class DetailsModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public DetailsModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public TipoAmbulatorio TipoAmbulatorio { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoAmbulatorio = await _context.TipoAmbulatorio.SingleOrDefaultAsync(m => m.TipoAmbulatorioID == id);

            if (TipoAmbulatorio == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
