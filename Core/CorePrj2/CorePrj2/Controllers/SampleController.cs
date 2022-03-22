using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePrj2.Models;

namespace CorePrj2.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Normal Method
        public dynamic SICalcMethod(int p, int n, int r)
        {
            int SI = (p * n * r) / 100;
            return SI;
        }

        //viewresult
        public ViewResult Information()
        {
            return View();
        }

        //content result
        public ContentResult Data()
        {
            return Content("<h1>This Is the data Content</h1>", "text/html");
        }

        //json result
        public JsonResult Getjson()
        {
            Student student = new Student();
            student.StdId = 7;
            student.StdName = "Banurekha";
            student.Gender = "Female";
            student.Discipline = "IT";
            return Json(student);
        }

        public IActionResult Getstudent()
        {
            Student student = new Student();
            student.StdId = 8;
            student.StdName = "Simi";
            student.Gender = "Female";
            student.Discipline = "IT";
            return Json(student);
        }
    }
}
