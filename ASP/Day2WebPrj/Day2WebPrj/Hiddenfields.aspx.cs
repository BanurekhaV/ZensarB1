using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2WebPrj
{
    public partial class Hiddenfields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Store_Click(object sender, EventArgs e)
        {
            HiddenField2.Value = TextBox1.Text;
            HiddenField3.Value = TextBox2.Text;
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;

        }

        protected void Load_Click(object sender, EventArgs e)
        {
            Label3.Text = HiddenField2.Value + HiddenField3.Value;
        }
    }
}