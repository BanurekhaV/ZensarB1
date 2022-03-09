using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2Prj.Models;

namespace Day2Prj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee() { Id = 100, FullName = "Banurekha", DOJ=DateTime.Now, Email = "banu@abc.com" };
            return View(e);
        }
        [ActionName("Data")]
        public ActionResult Sample()
        {
            return View("Sample");
        }
        [NonAction]
        public ActionResult NonactionMethod()
        {
            return View();
        }
    }
}