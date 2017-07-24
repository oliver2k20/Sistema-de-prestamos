using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableHtml.Models;

namespace TableHtml.Services
{
    public class repositorio
    {
        public List <cliente> ObtenerTodos()
        {
            using (var db = new Context())
            {
                return db.clientes.ToList();
            }
        }

        internal void Crear(cliente model)
        {
            using (var db = new Context())
            {
                db.clientes.Add(model);
                db.SaveChanges();
            }

        }
    }
}