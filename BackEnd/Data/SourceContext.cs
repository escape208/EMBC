using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class SourceContext : DbContext
    {
        public SourceContext (DbContextOptions<SourceContext> options)
            : base(options)
        {
        }

        public DbSet<BackEnd.Models.Source> Source { get; set; }
    }
}
