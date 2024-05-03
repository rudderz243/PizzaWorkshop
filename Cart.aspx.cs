using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaFactory
{
    public partial class Cart : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CartHolder.cart.Count == 0)
            {
                lblEmpty.Visible = true;
                dgCart.Visible = false;
                btnClearCart.Visible = false;
                btnSubmitOrder.Visible = false;
            }
            else
            {
                dgCart.DataSource = CartHolder.cart;
                dgCart.DataBind();
                //dgCart.Columns.RemoveAt(0);
                //dgCart.Columns.RemoveAt(4);



                lblEmpty.Visible = false;
                dgCart.Visible = true;
                btnClearCart.Visible = true;
                btnSubmitOrder.Visible = true;
            }
        }

        protected void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            da.SubmitOrder(CartHolder.cart);
        }

        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            CartHolder.cart.Clear();
        }
    }
}