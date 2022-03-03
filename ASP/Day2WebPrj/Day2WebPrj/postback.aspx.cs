using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class postback : System.Web.UI.Page
    {
        int Clickscount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Step 1
            //Clickscount = Clickscount + 1;
            //TextBox1.Text = Clickscount.ToString();

            //step2 using viewState variable/object (dictionary object)
            /* if(ViewState["clicks"]!=null)
             {
                 Clickscount = (int)ViewState["clicks"] + 1;
             }
             TextBox1.Text = Clickscount.ToString();
             ViewState["clicks"] = Clickscount;*/

            //step 3 making use of the inbuilt viewstate variables that are attached to every server control(asp control)
            Clickscount = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = Clickscount.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ViewState["name"].ToString();
        }
    }
}