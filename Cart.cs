using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory
{
    public static class CartHolder
    {
        public static List<Pizza> cart = new List<Pizza>();

    }
    public static class UserHolder
    {
        public static User loggedInUser;
    }
}