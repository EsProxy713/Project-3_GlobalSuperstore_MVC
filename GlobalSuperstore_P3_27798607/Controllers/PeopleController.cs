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
    public class PeopleController : Controller
    {
      
        private int pageSize = 8;
        // GET: People
        [Authorize]
        public ActionResult Index(int? page)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.people_collection =
                Models.MongoHelper.database.GetCollection<Models.People>("People");
            var filter = Builders<Models.People>.Filter.Ne("_id", "");
            var result = Models.MongoHelper.people_collection.Find(filter).ToList();
            return View(result.ToPagedList(page ?? 1, pageSize));
        }

        // GET: People/Details/5
        [Authorize]
        public ActionResult Detail(string id)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.people_collection =
            Models.MongoHelper.database.GetCollection<Models.People>("People");
            var filter = Builders<Models.People>.Filter.Eq("_id", id);
            var result = Models.MongoHelper.people_collection.Find(filter).FirstOrDefault();
            return View(result);
        }

        // GET: People/Create
        [Authorize]
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
        // POST: People/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Models.MongoHelper.ConnectToMongoService();
                Models.MongoHelper.people_collection =
                    Models.MongoHelper.database.GetCollection<Models.People>("People");

                //Generate an _id for our new entry
                Object id = GenerateRandomId(24);

                Models.MongoHelper.people_collection.InsertOneAsync(new Models.People
                {
                    _id = id,
                    Person = collection["Person"],
                    Region = collection["Region"]
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        [Authorize]
        public ActionResult Edits(string id)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.people_collection =
            Models.MongoHelper.database.GetCollection<Models.People>("People");
            var filter = Builders<Models.People>.Filter.Eq("_id", id);
            var result = Models.MongoHelper.people_collection.Find(filter).FirstOrDefault();
            return View(result);
        }

        // POST: People/Edit/5
        [HttpPost]
        [Authorize]
        public ActionResult Edits(string id, FormCollection collection)
        {
            try
            {
                Models.MongoHelper.ConnectToMongoService();
                Models.MongoHelper.people_collection =
                Models.MongoHelper.database.GetCollection<Models.People>("People");
                var filter = Builders<Models.People>.Filter.Eq("_id", id);
                var update = Builders<Models.People>.Update
                    .Set("Person", collection["Person"])
                    .Set("Region", collection["Region"]);
                var result = Models.MongoHelper.people_collection.UpdateOneAsync(filter, update);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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
