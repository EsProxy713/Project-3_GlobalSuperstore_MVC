using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalSuperstore_P3_27798607.Controllers
{
    public class VisualsController : Controller
    {
        // GET: Visuals
        public ActionResult Index()
        {
            return View();
        }

        // make the actionResults for all the views and then make all the views - try categorize as much as possible to limit number of views needed to be made


        // GET: Visuals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Visuals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visuals/Create
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

        // GET: Visuals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Visuals/Edit/5
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

        // GET: Visuals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Visuals/Delete/5
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
