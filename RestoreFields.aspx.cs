using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestoreFields
{
    public partial class RestoreFields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(ViewState["username"] != null && ViewState["password"] != null)
            //{
            //    username.Text = ViewState["username"].ToString();
            //    password.Text = ViewState["password"].ToString();
            //}
            if (IsPostBack)
            {

            }
            
            
        }
        protected void Submit(object sender, EventArgs e)
        {
            ViewState["username"] = username.Text;
            ViewState["password"] = password.Text;

            username.Text = "";
            password.Text = "";
        }

        protected void ViewStateRestore(object sender, EventArgs e)
        {
            if (ViewState["username"] != null)
            {
                username.Text = ViewState["username"].ToString();
            }
            else
            {
                ViewState["username"] = "";
            }

            if (ViewState["password"] != null)
            {
                password.Text = ViewState["password"].ToString();
            }
            else
            {
                ViewState["password"] = "";
            }
        }

        protected void HiddenFieldRestore(object sender, EventArgs e)
        {
            username.Text = hdnUsername.Value;
            password.Text = hdnPassword.Value;
        }
    }
}