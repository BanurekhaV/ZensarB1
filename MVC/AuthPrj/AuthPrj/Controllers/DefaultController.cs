using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthPrj.Controllers
{
   [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
            
        }
        
        public ActionResult AnonymousMethod()
        {
            return Content("Hello Anonymous User - Welcome !!");
        }


        [Authorize]
        public ActionResult AuthorisedMethod()
        {
            return Content("Hello Authorised User");
        }

        public ActionResult AdminHome()
        {
            return View();
        }

        public ActionResult CustomerHome()
        {
            return View();
        }
    }
}