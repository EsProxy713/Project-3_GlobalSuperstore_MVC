﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalSuperstore_P3_27798607.Controllers
{
    public class RoleController : Controller
    {
        //ApplicationDbContext context;
        public RoleController()
        {
       //     context = new ApplicationDbContext();
        }

      //  public ActionResult Index()
      //  {
      //      var Roles = context.Roles.ToList();
         //   return View();
      //  }

       // public ActionResult Create()
       // {
      //      var Role = new IdentityRole();
       //     return View(Role);
       // }

        // POST: Role/Create
        [HttpPost]
      //  public ActionResult Create(IdentityRole Role)
      //  {
      //      context.Roles.Add(Role);
       //     context.SaveChanges();
        //    return RedirectToAction("Index");
//}

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Role/Edit/5
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

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
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
