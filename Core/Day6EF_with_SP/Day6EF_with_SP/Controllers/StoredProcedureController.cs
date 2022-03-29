using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day6EF_with_SP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6EF_with_SP.Controllers
{
    public class StoredProcedureController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MostExpensiveProduct()
        {
            return View(model: db.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]"));
        }

        public IActionResult CustOrders()
        {
            string cid = "ALFKI";
            return View(db.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders]@p0", parameters: new[] { cid }).ToList());
        }


    }
}
