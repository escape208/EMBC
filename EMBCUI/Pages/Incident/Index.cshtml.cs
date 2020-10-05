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
    public class IndexModel : PageModel
    {
        private readonly BackEnd.Data.IncidentContext _context;

        public IndexModel(BackEnd.Data.IncidentContext context)
        {
            _context = context;
        }

        public IList<BackEnd.Models.Incident> Incident { get;set; }

        public async Task OnGetAsync()
        {
            Incident = await _context.Incident.ToListAsync();
        }
    }
}
