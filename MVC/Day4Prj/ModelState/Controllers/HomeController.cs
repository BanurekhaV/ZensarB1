using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateEg.Models;

namespace ModelStateEg.Controllers
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

        //Action method, if validations are successful
        public ActionResult UserStatus()
        {
            ViewBag.Status = "Validation Successful";
            return View();
        }

        //Model state with validations
        [HttpGet]
        public ActionResult AddUser()
        {
            User model = new User();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddUser(User model)
        {
            if(string.IsNullOrEmpty(model.Lastname))
            {
                ModelState.AddModelError("Lastname", "Last Name cannot be Blank");
            }
            if(model.Age<18 || model.Age >55)
            {
                ModelState.AddModelError("Age", "Age has to be between 18 and 55");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TempData["Lastname"] = model.Lastname;
                TempData["Age"] = model.Age;
                TempData.Keep();
                return RedirectToAction("UserStatus");
            }
        }
    }
}