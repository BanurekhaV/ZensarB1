using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthPrj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //to use session state variables to authenticate a user
        public ActionResult CheckUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckUser(FormCollection frm)
        {
            string emailid = frm["EmailId"];
            string password = frm["Password"];
            if(emailid.ToLower() == "admin@gmail.com" && password == "admin")
            {
                Session["username"] = emailid;
                return RedirectToAction("AdminHome", "Default");
            }
            else if(emailid.ToLower() == "customer@gmail.com" && password == "customer")
            {
                Session["username"] = emailid;
                return RedirectToAction("CustomerHome", "Default");
            }
            return View();
        }
    }
}