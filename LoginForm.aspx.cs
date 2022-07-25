using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] !=null && Session["password"] != null)
            {
                lol.InnerText = Session["username"].ToString() + " " + Session["password"].ToString() + "Login Details";

            }

        }

        protected void Login(object sender, EventArgs e)
        {
           if(username.Text == "polar" && password.Text == "vezli")
            {
                Session["username"] = username.Text;
                Session["password"] = password.Text;
                lol.InnerText = Session["username"].ToString() + " " + Session["password"].ToString() + "Login Details";

                Response.Redirect("GreetingsPage.aspx");
            }
        }
    }
}