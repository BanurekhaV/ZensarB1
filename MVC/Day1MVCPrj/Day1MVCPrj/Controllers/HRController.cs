using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVCPrj.Models;

namespace Day1MVCPrj.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
       //3. Calling ListDepartment action method of the same controller in the index of the same
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { ID = 1, DeptName = "CSE" });
            d.Add(new Department { ID = 2, DeptName = "EEE" });
            d.Add(new Department { ID = 3, DeptName = "ECE" });
            d.Add(new Department { ID = 4, DeptName = "IT" });
            d.Add(new Department { ID = 5, DeptName = "Mech" });
            return View("ListDepartment", d);
        }
        //2. view type list based on a model
        public ActionResult ListEmployeeDetails()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { ID = 1001, Name = "SaiKumar", Age = 22 });
            emplist.Add(new Employee { ID = 1002, Name = "Srikanth", Age = 22 });
            emplist.Add(new Employee { ID = 1003, Name = "Sai Venkat", Age = 22 });
            return View(emplist);
        }
        //1. view type details based on a model
        public ActionResult DisplayEmployee()
        {
            Employee Emp = new Employee() { ID = 200, Name = "Banu", Age = 27 };
            return View(Emp);
        }
        //4. the called action method ListDepartment from Index

        public ActionResult ListDepartment(Department d)
        {
            return View(d);
        }

        //5. calling action method of another controller(demo)- viewMethod
        public ActionResult CallviewMethod()
        {
            return View("~/Views/Demo/viewMethod.cshtml");
        }
        //6. calling the action method of another controller

        public ActionResult Rdirect_action_another_controller()
        {
            return RedirectToAction("Reply", "Demo");
        }
    }
}