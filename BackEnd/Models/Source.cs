using BackEnd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Source
    {
        public int ID { get; set; }

        [Required]
        public string SourceName { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

    }
}
