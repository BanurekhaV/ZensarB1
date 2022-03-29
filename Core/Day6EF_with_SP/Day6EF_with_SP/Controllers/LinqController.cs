using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day6EF_with_SP.Models;

namespace Day6EF_with_SP.Controllers
{
    public class LinqController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerbyCountry()
        {
            List<Customer> custlist = (from c in db.Customers
                                       where c.Country == "Germany"
                                       select c).ToList();
            return View(custlist);
        }

        //customer details for a given order id
        public ActionResult CustomerByorder()
        {
            List<Customer> custlist = (from o in db.Orders
                                       join c in db.Customers
                                       on o.CustomerId equals c.CustomerId
                                       where o.OrderId == 10248
                                       select c).ToList();
            return View(custlist);
        }
    }
}
