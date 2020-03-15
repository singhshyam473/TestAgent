using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application page with change text";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message ="Contact details";

            return View();
        }
    }
}