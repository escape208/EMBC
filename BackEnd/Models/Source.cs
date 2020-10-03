using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Source
    {
        public int ID { get; set; }

        [Required]
        public string URL { get; set; }

        public ICollection<Incident>? Incidents { get; set; }
    }
}
