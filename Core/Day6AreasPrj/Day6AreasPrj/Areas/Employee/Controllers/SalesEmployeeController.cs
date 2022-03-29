using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day6AreasPrj.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class SalesEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetEmployeeByLocation(int locationID)
        {
            Models.Employee[] employees = new Models.Employee[]
            {
                new Models.Employee
                {
                    ID = 1,
                    Name = "Prabhas",
                    Designation="Manager",
                    LocationID = 1
                },
                new Models.Employee
                {
                    ID = 2,
                    Name = "Mahesh Babu",
                    Designation="Developer",
                    LocationID = 1
                },
                new Models.Employee
                {
                    ID = 3,
                    Name = "Arjun",
                    Designation="Programmer",
                    LocationID = 2
                },
                new Models.Employee
                {
                    ID = 4,
                    Name = "Nithin",
                    Designation="Clerk",
                    LocationID = 2
                },
                new Models.Employee
                {
                    ID = 5,
                    Name = "Ram",
                    Designation="VP",
                    LocationID = 3
                },
            };

            Models.Employee[] emplist = employees.Where(e => e.LocationID == locationID).ToArray();
            return View(emplist);
        }
    }
}
