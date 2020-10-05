using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;
using BackEnd.Models;

namespace EMBCUI.Pages.Incident
{
    public class DeleteModel : PageModel
    {
        private readonly BackEnd.Data.IncidentContext _context;

        public DeleteModel(BackEnd.Data.IncidentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BackEnd.Models.Incident Incident { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Incident = await _context.Incident.FirstOrDefaultAsync(m => m.ID == id);

            if (Incident == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Incident = await _context.Incident.FindAsync(id);

            if (Incident != null)
            {
                _context.Incident.Remove(Incident);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
