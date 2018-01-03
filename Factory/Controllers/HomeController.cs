using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pizza aPizza1 = null;
            PizzaStore aPizzaStore = new Models.PizzaStore();

            aPizza1 = aPizzaStore.CreatePizza("Veggie");

            ViewBag.Pizza = aPizza1;

            return View();
        }
    }
}