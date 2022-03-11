using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Day3Prj.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        //1. Getting the data from view through FormCollection

        //using standard html helpers
        public ActionResult CreateRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegistration(FormCollection frm)
        {
            string name = frm["txtName"].ToString();
            string password = frm["txtpwd"].ToString();
            string gender = frm["Gender"].ToString();
            bool music = Convert.ToBoolean(frm["M"].Split(',')[0]);
            bool sports= Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool arts = Convert.ToBoolean(frm["A"].Split(',')[0]);
            string interest = "";
            if (music == true)
                interest += "Music";
            if (sports == true)
                interest += "Sports";
            if (arts == true)
                interest += "Arts";
            string city = frm["City"].ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append(name + "<br/>");
            sb.Append(password + "<br/>");
            sb.Append(gender + "<br/>");
            sb.Append(interest + "<br/>");
            sb.Append(city);
            return Content(sb.ToString());

        }


    }
}