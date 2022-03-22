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
        public string Index()
        {
            return"This is the Index View of Home";
        }

        public IActionResult GetDetails(int sid)
        {
            StudentRepository sr = new StudentRepository();
            Student stud = sr.GetStudentById(sid);
            return View(stud);
        }
    }
}
