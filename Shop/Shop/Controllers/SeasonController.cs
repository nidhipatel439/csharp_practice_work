using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class SeasonController : Controller
    {
        // GET: /Season/Index
        //GET: /Season
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Season/Show
        [HttpPost]
        public ActionResult Show(int? temp)
        {

            if (temp == null)
            {
                ViewBag.Temp = "unknown";
            }
            else
            {
                ViewBag.Temp = temp;
            }

            SeasonApiController controller = new SeasonApiController();
            ViewBag.Season = controller.Name(temp);
           
            return View();
        }
    }
}