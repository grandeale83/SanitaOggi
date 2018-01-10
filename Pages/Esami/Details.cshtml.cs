using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.Esami
{
    public class DetailsModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public DetailsModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public Esame Esame { get; set; }

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
            return Page();
        }
    }
}
