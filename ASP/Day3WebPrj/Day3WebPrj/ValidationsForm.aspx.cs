using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day3WebPrj
{
    public partial class ValidationsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Redirect("Valid.html");
            }
            else
            {
                Response.Write("Validations Failed");
            }
        }
    }
}