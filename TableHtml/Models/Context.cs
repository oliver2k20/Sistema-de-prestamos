using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TableHtml.Models
{
    public class Context : DbContext
    {

        public Context() 
            : base("Connection")
        {

        }

            public DbSet <cliente> clientes { get; set; }

    }
}