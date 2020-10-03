using BackEnd.Data;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DTOs
{
    public class IncidentReadDTO
    {
        public int ID { get; set; }

        public ICollection<Source>? Sources { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public DateTime? Date { get; set; }

        public int? Injuries { get; set; }

        public int? Deaths { get; set; }

    }
}
