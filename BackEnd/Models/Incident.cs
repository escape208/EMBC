using BackEnd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Incident
    {
        public int ID { get; set; }

        public ICollection<Source>? Sources { get; set; }

        [StringLength(200)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? State { get; set; }

        [StringLength(100)]
        public string? Country { get; set; }

        public DateTime? Date { get; set; }

        public int? Injuries { get; set; }

        public int? Deaths { get; set; }

    }
}
