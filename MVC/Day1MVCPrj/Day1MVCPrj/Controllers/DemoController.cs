using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVCPrj.Models;

namespace Day1MVCPrj.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //calling another controller's action method
        public ActionResult Index()
        {
            return Redirect("Home/About");
          //  return View();
        }
        public string NormalMethod()
        {
            return "Hi All !!";
        }

        public ViewResult viewMethod()
        {
            List<string> s = TempData["flowers"] as List<string>;
            return View(s);
        }
        //only for displaying set of string values --
        public ContentResult Reply()
        {
            // return Content("Good Morning All !!", "text/plain");
            return Content("<h1>Good Morning All !!</h1>", "text/html");
        }

        //Empty Result - where an action method does not return any view to the user
        [NonAction]
        public EmptyResult Empty()
        {
            int amount = 45000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }

        //json result
        public JsonResult Employee()
        {
            Employee E = new Employee();
            E.ID = 101;
            E.Name = "Sunil";
            E.Age = 25;
            return Json(E, JsonRequestBehavior.AllowGet);
        }

        //calling different action method of the same controller
        public RedirectResult Redirection()
        {
           return Redirect("Employee");
        }

    }
}