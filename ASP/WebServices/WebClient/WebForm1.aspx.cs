using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sqbtn_click(object sender, EventArgs e)
        {
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            float f=client.Square(float.Parse(txtnumber.Text));
            Label1.Text = f.ToString();

        }

        protected void msgbtn_click(object sender, EventArgs e)
        {
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            string str = client.HelloWorld(txtName.Text);
            Label1.Text = str;
        }
    }
}