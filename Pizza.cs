using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory
{
    public class Pizza
    {
        public int pizzaID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }
    }
}