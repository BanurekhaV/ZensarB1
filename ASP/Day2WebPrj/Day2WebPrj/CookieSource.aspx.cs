using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Redirect_Click(object sender, EventArgs e)
        {
            //persistant cookies
            /*HttpCookie hc = new HttpCookie("Mynewcookie");
            hc["d1"] = TextBox1.Text;
            hc["d2"] = TextBox2.Text;
            Response.Cookies.Add(hc);
            Response.Redirect("CookieDestination.aspx");*/

            //non-persistant cookie
            Response.Cookies["c1"].Value = TextBox1.Text;
            Response.Cookies["c2"].Value = TextBox2.Text;
            Response.Redirect("CookieDestination.aspx");
        }
    }
}