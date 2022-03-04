using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class QueryDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Retrieve_Click(object sender, EventArgs e)
        {
             Label2.Text = Request.QueryString["uname"];
             Label1.Text = Request.QueryString["Contact"];
            //string temp;
            //temp = "Name:" + Request.QueryString["QS1"].ToString();
            //temp += "--Contact:" + Request.QueryString["QS2"].ToString();
            //Label1.Text = temp;

        }
    }
}