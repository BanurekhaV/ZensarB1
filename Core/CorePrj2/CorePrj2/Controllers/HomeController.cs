using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePrj2.Models;

namespace CorePrj2.Controllers
{
    public class HomeController : Controller
    {
        //creating a reference variable/object of the Service interface 
        readonly IStudentRepository isr = null;

        //Initialize the read only variable in the constructor 
        //injecting the services object(interface) into the constructor of the class)
        //public HomeController(IStudentRepository repo)
        //{
        //    isr = repo;
        //}

        
        public JsonResult Index()
        {
            List<Student> all = isr.GetAllStudents();
            return Json(all);
        }

        public JsonResult GetStudentDetails(int sid)
        {
            Student student = isr.GetStudentById(sid);
            return Json(student);
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
