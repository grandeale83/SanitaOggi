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
    public class IndexModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public IndexModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public IList<Esame> Esame { get;set; }

        public async Task OnGetAsync()
        {
            Esame = await _context.Esame.ToListAsync();
        }
    }
}
