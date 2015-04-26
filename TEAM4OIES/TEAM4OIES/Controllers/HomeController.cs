using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TEAM4OIES.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "TEAM4OIES";
          

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
