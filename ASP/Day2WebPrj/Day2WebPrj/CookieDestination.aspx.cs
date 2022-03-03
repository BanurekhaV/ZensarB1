using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetData_Click(object sender, EventArgs e)
        {
            //we will read data from a persistant cookie that is travelling from the previous page
            /* HttpCookie ct = Request.Cookies["Mynewcookie"];
             Label1.Text = ct["d1"];
             Label2.Text = ct["d2"];*/

            //non-persistant cookie (reading value from the previous page)
            Label1.Text = Request.Cookies["c1"].Value.ToString();
            Label2.Text = Request.Cookies["c2"].Value.ToString();
            Response.Redirect("Viewstateform.aspx");
        }
    }
}