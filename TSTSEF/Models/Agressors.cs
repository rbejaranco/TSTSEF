using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TSTSEF.Models
{
    public class Agressor
    {
        public int AgressorId { get; set; }
        public string AgressorName { get; set; }
        public virtual ICollection<Relative> Relatives { get; set; }
    }

}