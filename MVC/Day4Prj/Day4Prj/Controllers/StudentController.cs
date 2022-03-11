using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4Prj.Models;

namespace Day4Prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
             return View();
        }

        //strongly typed helper
        public ActionResult StronglyTypedCreate()
        {
            return View();
        }

        //templated helper
        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //editor for helper
        public ActionResult EditorForModel()
        {
            return View();
        }
        //Passing data /binding model data using Request Object
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost,ActionName("Create")]
        public ActionResult CreatePost()
        {
            Student student = new Student();
            student.RollNo = Convert.ToInt32(Request["RollNo"]);
            student.Name = Request["Name"].ToString();
            student.Gender = Request["Gender"].ToString();
            student.Address = Request["Address"].ToString();
            return Json(student, JsonRequestBehavior.AllowGet);
        }

        //using custom helpers
        public ActionResult CustomeHelpersView()
        {
            return View();
        }
    }
}