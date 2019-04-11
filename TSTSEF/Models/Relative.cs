using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSTSEF.Models
{
    public class Relative
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Relation { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int AgressorId {get;set;}
    }
}