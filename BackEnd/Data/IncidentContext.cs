using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class IncidentContext : DbContext
    {
        public IncidentContext (DbContextOptions<IncidentContext> options)
            : base(options)
        {
        }

        public DbSet<BackEnd.Models.Incident> Incident { get; set; }
    }
}
