
using PPPK_MVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPPK_MVC.Controllers
{
    public class VozacController : Controller
    {
        IRepo repo = RepoFactory.GetRepo();
        // GET: Vozac
        public ActionResult ViewAll()
        {
            return View(repo.GetVozaci());
        }

        // GET: Vozac/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vozac/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vozac/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vozac/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vozac/Edit/5
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

        // GET: Vozac/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vozac/Delete/5
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
