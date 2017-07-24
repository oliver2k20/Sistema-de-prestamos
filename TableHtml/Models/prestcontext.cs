using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TableHtml.Models
{
    public class prestcontext: DbContext
    {
        public prestcontext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<prestamo> prestamoes { get; set; }
    }
}