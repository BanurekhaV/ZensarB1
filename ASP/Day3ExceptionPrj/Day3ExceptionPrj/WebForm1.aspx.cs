using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Day3ExceptionPrj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // try
            //{
            //DataSet ds = new DataSet();
            //ds.ReadXml(Server.MapPath("~/Countries.xml"));
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            //}
            //catch (System.IO.FileNotFoundException fnfe)
            //{
            //    LblResult.Text = "File is missing";
            //}

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL;initial catalog=ZensarDB;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from employee1", con);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();
            Response.Write(ex.GetType());
            Server.Transfer("~/Errors.aspx");
        }
    }
}