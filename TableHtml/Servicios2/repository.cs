using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableHtml.Models;

namespace TableHtml.Servicios2
{
    public class repository
    {
       
        
            public List<prestamo> Addall()
            {
                using (var db = new prestcontext())
                {
                    return db.prestamoes.ToList();
                }
            }
        }
    }

