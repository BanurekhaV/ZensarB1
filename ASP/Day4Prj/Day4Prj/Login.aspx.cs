using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Day4Prj
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(UserName.Text,Password.Text))
            {
                //    Response.Write("Welcome");
                //    Response.Redirect("Welcome.aspx");
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, RememberChk.Checked);
            }
            else
            {
                Display.Text = "Inavlid User Name and/or Password";
               // Response.Write("Welcome");
            }
        }
    }
}