using Core5EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core5EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository emprepo;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepository erepo)
        {
            _logger = logger;
            emprepo = erepo;
        }

        public IActionResult Index()
        {
            var empmodel = emprepo.GetAllEmployees();
            return View(empmodel);
        }

        public ViewResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            emprepo.AddEmployee(emp);
            return RedirectToAction("Index");
        }

        public IActionResult GetEmployeeById(int Id)
        {
           Employee employee= emprepo.GetEmployeeById(Id);
            return View(employee);
        }
        public IActionResult Edit(int ID)
        {
            Employee emp =emprepo.GetEmployeeById(ID);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            emprepo.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            emprepo.DeleteEmployee(Id);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
