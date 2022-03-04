using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class QuerySource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         protected void Redirect_Click(object sender, EventArgs e)
        {
            //string url;
            //url = "QueryDestination.aspx?QS1="+TextBox1.Text;
            //url +="&QS2=" +TextBox2.Text;
            //Response.Redirect(url);

            Response.Redirect("QueryDestination.aspx?uname=" + TextBox1.Text + "&Contact=" + TextBox2.Text);
        }
    }
}