using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace GlobalSuperstore_P3_27798607.Models
{
    public class Orders
    {
        //[BsonId]
       // [BsonRepresentation(BsonType.ObjectId)]
        public Object _id { get; set; }

        //[BsonElement("Row ID")]
        [Display(Name = "Row ID")]
        public string Row_ID { get; set; }

        //  [BsonElement("Order ID")]
        [Display(Name = "Order ID")]
        public string Order_ID { get; set; }

        // [BsonElement("Order Date")]
        [Display(Name = "Order Date")]
        public string Order_Date { get; set; }

        //  [BsonElement("Ship Date")]
        [Display(Name = "Ship Date")]
        public string Ship_Date { get; set; }

        //  [BsonElement("Ship Mode")]
        [Display(Name = "Ship Mode")]
        public string Ship_Mode { get; set; }

        //[BsonElement("Customer ID")]
        [Display(Name = "Customer ID")]
        public string Customer_ID { get; set; }

        public string Segment { get; set; }

        //  [BsonElement("Postal Code")]
        [Display(Name = "Postal Code")]
        public string Postal_Code { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Market { get; set; }

        // [BsonElement("Product ID")]
        [Display(Name = "Product ID")]
        public string Product_ID { get; set; }

        public string Category { get; set; }

        //  [BsonElement("Sub-Category")]
        [Display(Name = "Sub-Category")]
        public string Sub_Category { get; set; }

        // [BsonElement("Product Name")]
        [Display(Name = "Product Name")]
        public string Product_Name { get; set; }

        public string Sales { get; set; }

        public string Quantity { get; set; }

        public string Discount { get; set; }

        public string Profit { get; set; }

        // [BsonElement("Shipping Cost")]
        [Display(Name = "Shipping Cost")]
        public string Shipping_Cost { get; set; }

        // [BsonElement("Order Priority")]
        [Display(Name = "Order Priority")]
        public string Order_Priority { get; set; }
    }
}