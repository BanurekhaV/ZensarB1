using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePrj2.Models;

namespace CorePrj2.Controllers
{
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayPerson()
        {
            Person person = new Person();
            person.Id = 101;
            person.PersonName = "Abhinaya";
            person.City = "Goa";
            return View(person);
        }

        //viewbag/viewdata
        public IActionResult ShowMobile()
        {
            List<string> mobiles = new List<string>() { "Samsung", "Redmi", "Oppo", "OnePlus", "Xiomi" };
            ViewData["androids"] = mobiles;
            ViewBag.mobilebag = mobiles;
            return View();
        }
    }
}
