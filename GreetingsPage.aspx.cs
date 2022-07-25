using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class GreetingsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            greeting.InnerText = "Hello there, Mr. " + Session["username"];

        }

        protected void Logout(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["password"] = "";

            Response.Redirect("LoginForm.aspx");
        }
    }
}