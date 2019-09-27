using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace GlobalSuperstore_P3_27798607.Models
{
    public class MongoHelper
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://Admin:Washburn713@globalsuperstore27798607-mvtdw.azure.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "test";

        public static IMongoCollection<Models.People> people_collection { get; set; }
        public static IMongoCollection<Models.Orders> orders_collection { get; set; }
        public static IMongoCollection<Models.Returns> returns_collection { get; set; }

        internal static void ConnectToMongoService()
        {

            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}