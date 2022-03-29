using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day6AreasPrj.Areas.Department.Models;

namespace Day6AreasPrj.Areas.Department.Controllers
{
    [Area("Department")]
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            Location[] saleslocation = new Location[]
            {
               new Location
               {
                   ID = 1,
                   Address="123 Road A",
                   City="Mumbai"
               },
               new Location
               {
                   ID = 2,
                   Address="456 Road B",
                   City="Bangalore"
               },
               new Location
               {
                   ID = 3,
                   Address="789 Road C",
                   City="Chennai"
               },
               new Location
               {
                   ID = 4,
                   Address="1011 Road D",
                   City="Hyderabad"
               },
            };
            return View(saleslocation);
        }
    }
}
