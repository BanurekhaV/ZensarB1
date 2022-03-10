using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2EFPrj.Models;

namespace Day2EFPrj.Controllers
{
    public class MutiTableController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: MutiTable
        
        public ActionResult Index()
        {
            List<Region> reg = ne.Regions.ToList();
            return View(reg);
        }

        //to view data from multiple Tables using navigation properties
        public ActionResult Cust_Orders_Details()
        {
            return View(ne.Orders.ToList());
        }

        //call a procedure
        [ActionName("ExpensiveProducts")]
        public ActionResult Proc_Expensive_Products()
        {
            return View("Proc_Expensive_Products", ne.Ten_Most_Expensive_Products());
        }

        //passing data from views to controllers using arguments/parameters
        //Note: parameter names should be similar to the routevalue(property name)

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int RegionID, string RegionDescription)
        {
            Region r = new Region();
            r.RegionID = RegionID;
            r.RegionDescription = RegionDescription;
            ne.Regions.Add(r);
            ne.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}