using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Day1WebFormPrj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                // try
                //{
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Countries1.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
                // }
                //catch(System.IO.FileNotFoundException fnfe)
                //{
                //    LblResult.Text = "File is missing";
                //}
            }

            //protected void Page_Error(object sender, EventArgs e)
            //{
            //    Exception ex = Server.GetLastError();
            //    Server.ClearError();
            //    Response.Redirect("~/ErrorPage.aspx");
            //}
        }

    }
    