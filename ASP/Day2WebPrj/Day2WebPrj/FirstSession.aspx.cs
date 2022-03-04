using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class FirstSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SetSession_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["city"] = TextBox2.Text;
            Response.Redirect("SecondSession.aspx");
        }
    }
}