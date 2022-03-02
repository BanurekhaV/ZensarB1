using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1WebPrj
{
    public partial class Form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page load Successful." + "<br/>");
        }

        protected void Page_initComplete(object sender, EventArgs e)
        {
            Response.Write("Page  Init  complete Successfull.." + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init Successfull.." + "<br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page Pre Init Successfull.." + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page Pre Load Successfull.." + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render  Successfull.." + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
          //  Response.Write("Page unloading Successfull..");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page Render Successfull.." + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page Render Complete Successfull.." + "<br/>");
        }
    }
}