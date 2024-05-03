using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaFactory
{
    public partial class Menu : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        static List<Pizza> menu = new List<Pizza>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                menu = da.GetAllPizzas();
                pizzaRepeater.DataSource = menu;
                pizzaRepeater.DataBind();

            }
        }



        protected void btnAddToCart_Command(object sender, CommandEventArgs e)
        {


        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int pizzaID = Convert.ToInt32(btn.CommandArgument);

            foreach (Pizza pizza in menu)
            {
                if (pizza.pizzaID == pizzaID)
                {
                    CartHolder.cart.Add(pizza);
                    break;
                }
            }
        }
    }
}