using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory
{
    public class Order
    {
        public int orderID { get; set; }
        public DateTime orderTime { get; set; }
        public double orderTotal { get; set; }
        public string orderDetails { get; set; }
        public int userID { get; set; }
        public string status { get; set; }
    }
}