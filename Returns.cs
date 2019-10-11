using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalSuperstore_P3_27798607.Models
{
    public class Returns
    {
     
        public Object _id { get; set; }


        public string Returned { get; set; }


        [Display(Name = "Order ID")]
        public string Order_ID { get; set; }


        public string Region { get; set; }
    }
}