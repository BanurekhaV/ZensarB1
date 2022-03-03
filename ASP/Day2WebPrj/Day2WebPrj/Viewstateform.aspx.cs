using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class Viewstateform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Store_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["pswd"] = TextBox2.Text;
            TextBox1.Text = "";
            TextBox2.Text = string.Empty;
        }

        protected void Load_Click(object sender, EventArgs e)
        {
           // string uname = ViewState["name"].ToString();
            //string pass = ViewState["pswd"].ToString();
            //Label3.Text = "Your Name is " + uname + " " + "and your password:" + pass;
            //Label3.Text = "your name is " + ViewState["name"].ToString() + " and your password :" + ViewState["pswd"].ToString();
            // Response.Redirect("postback.aspx");

            Label3.Text = Request.Cookies["c1"].Value.ToString();
        }
    }
}