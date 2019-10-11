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
    public class OrdersController : Controller
    {
        private int pageSize = 5;
        // GET: Orders
        public ActionResult Index(int? page)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.orders_collection =
                Models.MongoHelper.database.GetCollection<Models.Orders>("Orders");
            var filter = Builders<Models.Orders>.Filter.Ne("_id","");
            var result = Models.MongoHelper.orders_collection.Find(filter).ToList();
            return View(result.ToPagedList(page ?? 1, pageSize));
        }

        // GET: Orders/Details/5
        public ActionResult Details(string id)
        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.orders_collection =
            Models.MongoHelper.database.GetCollection<Models.Orders>("Orders");
            var filter = Builders<Models.Orders>.Filter.Eq("_id", id);
            var result = Models.MongoHelper.orders_collection.Find(filter).FirstOrDefault();
            return View(result);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Models.MongoHelper.ConnectToMongoService();
                Models.MongoHelper.orders_collection =
                    Models.MongoHelper.database.GetCollection<Models.Orders>("Orders");

                //Generate an _id for our new entry
                Object id = GenerateRandomId(24);

                Models.MongoHelper.orders_collection.InsertOneAsync(new Models.Orders
                {
                    _id = id,
                    Row_ID = collection["Row_ID"],
                    Order_ID = collection["Order_ID"],
                    Order_Date = collection["Order_Date"],
                    Ship_Date = collection["Ship_Date"],
                    Ship_Mode = collection["Ship_Mode"],
                    Customer_ID = collection["Customer_ID"],
                    Segment = collection["Segment"],
                    Postal_Code = collection["Postal_Code"],
                    City = collection["City"],
                    State = collection["State"],
                    Country = collection["Country"],
                    Region = collection["Region"],
                    Market = collection["Market"],
                    Product_ID = collection["Product_ID"],
                    Category = collection["Category"],
                    Sub_Category = collection["Sub_Category"],
                    Product_Name = collection["Product_Name"],
                    Sales = collection["Sales"],
                    Quantity = collection["Quantity"],
                    Discount = collection["Discount"],
                    Profit = collection["Profit"],
                    Shipping_Cost = collection["Shipping_Cost"],
                    Order_Priority = collection["Order_Priority"]
                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static Random random = new Random();
        private object GenerateRandomId(int v)
        {
            string strarray = "abcdefghijklmnopqrstuvwxyz123456789";
            return new string(Enumerable.Repeat(strarray, v).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(string id)

        {
            Models.MongoHelper.ConnectToMongoService();
            Models.MongoHelper.orders_collection =
            Models.MongoHelper.database.GetCollection<Models.Orders>("Orders");
            var filter = Builders<Models.Orders>.Filter.Eq("_id", id);
            var result = Models.MongoHelper.orders_collection.Find(filter).FirstOrDefault();
            return View(result);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                Models.MongoHelper.ConnectToMongoService();
                Models.MongoHelper.orders_collection =
                Models.MongoHelper.database.GetCollection<Models.Orders>("Orders");
                var filter = Builders<Models.Orders>.Filter.Eq("_id", id);
                var update = Builders<Models.Orders>.Update
                    .Set("Row_ID", collection["Row_ID"])
                    .Set("Order_ID", collection["Order_ID"])
                    .Set("Order_Date", collection["Order_Date"])
                    .Set("Ship_Date", collection["Ship_Date"])
                    .Set("Ship_Mode", collection["Ship_Mode"])
                    .Set("Customer_ID", collection["Customer_ID"])
                    .Set("Segment", collection[""])
                    .Set("Postal_Code", collection[""])
                    .Set("City", collection["City"])
                    .Set("State", collection["State"])
                    .Set("Country", collection["Country"])
                    .Set("Region", collection["Region"])
                    .Set("Market", collection["Market"])
                    .Set("Product_ID", collection["Product_ID"])
                    .Set("Category", collection["Category"])
                    .Set("Sub_Category", collection["Sub_Category"])
                    .Set("Product_Name", collection["Product_Name"])
                    .Set("Sales", collection["Sales"])
                    .Set("Quantity", collection["Quantity"])
                    .Set("Discount", collection["Discount"])
                    .Set("Profit", collection["Profit"])
                    .Set("Shipping_Cost", collection["Shipping_Cost"])
                    .Set("Order_Priority", collection["Order_Priority"]);
                var result = Models.MongoHelper.orders_collection.UpdateOneAsync(filter, update);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orders/Delete/5
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
