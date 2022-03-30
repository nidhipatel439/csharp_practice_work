using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeShop.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        //Post: Shop/Checkout
        [HttpPost]
        public ActionResult Checkout(int number)
        {
            ViewData["number"] = number;
            return View();
        }
    }
}