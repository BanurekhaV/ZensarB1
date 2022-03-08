using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1MVCPrj.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rules()
        {
            List<string> rule = new List<string>()
            { "Avoid T-Shirt", "Carry your ID card","Be on Time"};

            //viewbag object to transfer data to view
            ViewBag.GetRules = rule as List<string>;

            //using ViewData to transfer data to vies
            ViewData["Followrules"] = rule as List<string>;
            return View();
        }

        //to check if the viewbag/data values can be sent to other requests
        public ActionResult TestData()
        {
            ViewBag.checkdata = "My New Data";
            ViewData["testdata"] = "My new TestData";
            return View(); //can get the data in the view
           // return Redirect("Index"); // data cannot be recd in other action method view of the same controller
           // return RedirectToAction("viewMethod", "Demo"); //data cannot be recd in other action methods view of another
        }

        //using TempData to retain values across requests
        public ActionResult FirstRequest()
        {
            List<string> tempval = new List<string>();
            tempval.Add("Roses");
            tempval.Add("Lilies");
            tempval.Add("Jasmine");
            tempval.Add("Mogra");
            //create a tempdata and store the list of flowers(tempval)
            TempData["flowers"] = tempval;
            TempData.Keep();
            return View();
        }

        public ActionResult SecondRequest()
        {
            List<string> strlist = TempData["flowers"] as List<string>;
            TempData.Keep();
            //  return View(strlist);
            return RedirectToAction("viewMethod", "Demo");
        }
    }
}