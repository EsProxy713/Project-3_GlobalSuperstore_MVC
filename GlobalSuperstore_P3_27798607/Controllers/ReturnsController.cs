using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace GlobalSuperstore_P3_27798607.Controllers
{
    public class ReturnsController : Controller
    {
        private int pageSize = 8;
        // GET: Returns
        public ActionResult Index(int? page)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.returns_collection =
                Models.MongoHelper.database.GetCollection<Models.Returns>("Returns");
            var filter = Builders<Models.Returns>.Filter.Ne("_id", "");
            var result = Models.MongoHelper.returns_collection.Find(filter).ToList();
            return View(result.ToPagedList(page ?? 1, pageSize));
        }

        // GET: Returns/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Returns/Create
        public ActionResult Create()
        {
            return View();
        }
        private static Random random = new Random();
        private object GenerateRandomId(int v)
        {
            string strarray = "abcdefghijklmnopqrstuvwxyz123456789";
            return new string(Enumerable.Repeat(strarray, v).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // POST: Returns/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.MongoHelper.ConnectToMongoService();
                Models.MongoHelper.returns_collection =
                    Models.MongoHelper.database.GetCollection<Models.Returns>("Returns");

                //Generate an _id for our new entry
                Object id = GenerateRandomId(24);

                Models.MongoHelper.returns_collection.InsertOneAsync(new Models.Returns
                {
                    _id = id,
                    Returned = collection["Returned"],
                    Order_ID = collection["Order_ID"],
                    Region = collection["Region"]
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Returns/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Returns/Edit/5
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

        // GET: Returns/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Returns/Delete/5
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
