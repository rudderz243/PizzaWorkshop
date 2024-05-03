using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaFactory
{
    public partial class Login : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User temp = da.LoginUser(edtLoginEmail.Text.ToString(), edtLoginPassword.Text.ToString());
            if (temp != null)
            {
                UserHolder.loggedInUser = temp;
                Response.Redirect("~/Default");
            }
            else
            {
                // please verify your login information
            }
        }
    }
}