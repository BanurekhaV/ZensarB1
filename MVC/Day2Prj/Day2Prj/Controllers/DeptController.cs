using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2Prj.Models;

namespace Day2Prj.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            List<Department> dlist = new List<Department>();
            
                dlist.Add(new Department { ID = 10, DeptName = "IT"});
                dlist.Add(new Department { ID = 20, DeptName = "Finance" });
                dlist.Add(new Department { ID = 30, DeptName = "Admin" });
                dlist.Add(new Department { ID = 40, DeptName = "HR" });
            
            return View("ListofDepts",dlist);
        }
        
        public ActionResult ListofDepts(Department d)
        {
            return View(d);
        }
    }
}