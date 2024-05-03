using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaFactory
{
    public partial class NewProduct : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserHolder.loggedInUser.staff)
                {
                    divAdd.Visible = true;
                    lblWarning.Visible = false;
                }
                else
                {
                    divAdd.Visible = false;
                    lblWarning.Visible = true;
                }
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Pizza temp = new Pizza
            {
                name = txtName.Text.ToString(),
                description = txtDescription.Text.ToString(),
                imageURL = txtURL.Text.ToString(),
                price = Convert.ToDouble(txtPrice.Text.ToString())
            };
            da.AddNewPizza(temp);
        }
    }
}