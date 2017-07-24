using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TableHtml.Models;
using TableHtml.Services;

namespace TableHtml.Controllers
{
    public class clientController : Controller
    {
        private repositorio repo;

        public clientController()
        {
            repo = new repositorio();
        }
        // GET: client
        public ActionResult Index()
        {
            var model = repo.ObtenerTodos();
            return View(model);
        }

        // GET: client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: client/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: client/Create
        [HttpPost]
        public ActionResult Create(cliente model)
        {
            try
            {
              if (ModelState.IsValid)
                {
                    repo.Crear(model);
                    return RedirectToAction("Index");

                }

                
            }
            catch (Exception ex)
            {
                //Log ex
            }
            return View(model);
        }

        // GET: client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
