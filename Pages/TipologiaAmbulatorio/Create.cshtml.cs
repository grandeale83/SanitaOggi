﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SanitaOggi.Models;

namespace SanitaOggi.Pages.TipologiaAmbulatorio
{
    public class CreateModel : PageModel
    {
        private readonly SanitaOggi.Models.SanitaContext _context;

        public CreateModel(SanitaOggi.Models.SanitaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TipoAmbulatorio TipoAmbulatorio { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TipoAmbulatorio.Add(TipoAmbulatorio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}