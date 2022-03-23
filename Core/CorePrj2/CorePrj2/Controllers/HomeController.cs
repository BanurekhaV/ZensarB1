using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePrj2.Models;

namespace CorePrj2.Controllers
{
    [Route("Start")]
    public class HomeController : Controller
    {
        //creating a reference variable/object of the Service interface 
        readonly IStudentRepository isr = null;

        //Initialize the read only variable in the constructor 
        //injecting the services object(interface) into the constructor of the class)
        public HomeController(IStudentRepository repo)
        {
            isr = repo;
        }

        //to inject the dependency in the method
        //public JsonResult Index([FromServices]IStudentRepository isrrepo)
        //{
        //    List<Student> all = isrrepo.GetAllStudents();
        //    return Json(all);
        //}
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("")]
        //[Route("Start")]
        //[Route("Start/Index")]
        [Route("")]
        [Route("/")]
        [Route("Index")]
        public JsonResult Index()
        {
            List<Student> all = isr.GetAllStudents();
            return Json(all);
        }
        //[Route("Start/Details/{id?}")]
        [Route("Details/{id?}")]
        public JsonResult GetStudentDetails(int sid)
        {
            Student student = isr.GetStudentById(sid);
            return Json(student);
        }
        [Route("~/Test")]
        public string TestMethod()
        {
            return "I am following Ignore Route";
        }

        //before injection application services
        //public JsonResult Index()
        //{
        //    StudentRepository sr = new StudentRepository();
        //    List<Student> allstudents = sr.GetAllStudents();
        //    return Json(allstudents);
        //}

        ////action method to call one of the implented services of student repository
        //public IActionResult GetStudentDetails(int sid)
        //{
        //    StudentRepository sr1 = new StudentRepository();
        //    Student stud = sr1.GetStudentById(sid);
        //    return Json(stud);
        //}

        //using the application services injected thru constructor


    }
}
