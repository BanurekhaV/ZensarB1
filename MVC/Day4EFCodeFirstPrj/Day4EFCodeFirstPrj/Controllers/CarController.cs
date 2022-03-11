using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4EFCodeFirstPrj.Models;

namespace Day4EFCodeFirstPrj.Controllers
{
    public class CarController : Controller
    {

        CarContext cc = new CarContext();
        // GET: Car
        public ActionResult Index()
        {
            List<Car> carlist = cc.cars.ToList();
            return View(carlist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Car c)
        {
            cc.cars.Add(c);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}