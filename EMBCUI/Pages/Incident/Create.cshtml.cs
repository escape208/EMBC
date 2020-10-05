using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BackEnd.Data;
using BackEnd.Models;

namespace EMBCUI.Pages.Incident
{
    public class CreateModel : PageModel
    {
        private readonly BackEnd.Data.IncidentContext _context;

        public CreateModel(BackEnd.Data.IncidentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BackEnd.Models.Incident Incident { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Incident.Add(Incident);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
