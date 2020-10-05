using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EMBCUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IncidentContext _incident;

        public int NumDeaths { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IncidentContext incident)
        {
            _logger = logger;
            _incident = incident;
        }

        public void OnGet()
        {
            LoadNumberOfDeaths();
        }

        private void LoadNumberOfDeaths()
        {
            var incidents = _incident.Incident
                .ToList();
            
            foreach (var incident in incidents)
            {
                if (incident.Deaths != null)
                {
                    NumDeaths = NumDeaths + Convert.ToInt32(incident.Deaths);
                }
            }

        }
    }
}
