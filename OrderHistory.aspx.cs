using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaFactory
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static List<Order> orders = new List<Order>();
        DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserHolder.loggedInUser.staff)
                {
                    orders = da.GetAllOrders();
                    ddlOrderSelection.Visible = true;
                    ddlOrderUpdate.Visible = true;
                    btnUpdateOrder.Visible = true;
                    lblOrderSelect.Visible = true;
                    lblOrderUpdate.Visible = true;
                    ddlOrderSelection.DataSource = orders;
                    ddlOrderSelection.DataTextField = "orderID";
                    ddlOrderSelection.DataValueField = "orderID";
                    ddlOrderSelection.DataBind();

                }
                else
                {
                    orders = da.GetUserOrders(UserHolder.loggedInUser.id);
                    ddlOrderSelection.Visible = false;
                    ddlOrderUpdate.Visible = false;
                    btnUpdateOrder.Visible = false;
                    lblOrderSelect.Visible = false;
                    lblOrderUpdate.Visible = false;
                }
                dgOrder.DataSource = orders;
                dgOrder.DataBind();
            }
        }

        protected void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string updatedStatus = ddlOrderUpdate.SelectedValue.ToString();
            int orderID = Convert.ToInt32(ddlOrderSelection.SelectedValue.ToString());
            da.UpdateOrder(orderID, updatedStatus);
        }
    }
}