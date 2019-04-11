using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TSTSEF.Models
{
    public class AgressorsDb : DbContext
    {
        public AgressorsDb() : base("DefaultConnection")
        { }

        public DbSet<Relative> Relatives { get; set; }
        public DbSet<Agressor> Agressors { set; get; }
        
    }
}