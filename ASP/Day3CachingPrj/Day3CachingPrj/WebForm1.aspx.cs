using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Day3CachingPrj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL;initial catalog=ZensarDB;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            Label1.Text = "This Page is Cached" +" " + DateTime.Now.ToString();


          /*  Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); //duration
            Response.Cache.VaryByParams["None"] = true; //varyby param
            Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);//location
             */
        }
    }
}