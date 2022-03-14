using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelBinding.Models;
using CustomModelBinding.CustomBinders;

namespace CustomModelBinding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        //Register the ModelBinder in the controller as below 
        // we can also register in the Global.asax
        [HttpPost]

        public ActionResult Index([ModelBinder(typeof(CustomDataBinder))] CustomModel cm)
        {
            ViewBag.CustTitle = cm.Title;
            ViewBag.DateHired = cm.DateHired;
            return View(cm);
        }

        [Authorize]
        public ActionResult Method1()
        {
            return Content("hi");
        }

    }
}