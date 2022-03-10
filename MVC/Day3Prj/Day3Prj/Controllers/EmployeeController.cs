using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3Prj.Models;

namespace Day3Prj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeDetails()
        {
            //collect Employee Info
            Employee emp = new Employee()
            {
                EmployeeId = 111,
                EmpName = "Dinesh",
                Department = "IT",
                Salary = 25000,
                AddressId = 1

            };

            //collect Address info

            Address addr = new Address()
            {
                AddressId = 1,
                City = "Mangalore",
                State = "Karnataka",
                Country = "India",
            };

            //create a viewmodel object
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = emp,
                address = addr,
                PageTitle = "Employee Personal Details"
            };

            //pass the viewmodel object to the view

            return View(empadd);
        }
    }
}