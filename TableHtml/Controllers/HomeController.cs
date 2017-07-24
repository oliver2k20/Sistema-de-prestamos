using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using TableHtml.Models;

namespace TableHtml.Controllers
{
    public class HomeController : Controller
    {
        DefaultConnectionEntities contexto = null;

        public ActionResult Index()
        {
            contexto = new DefaultConnectionEntities();
            List<prestamoes> loan = contexto.prestamoes.Take(10).ToList();
            return View(loan);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}