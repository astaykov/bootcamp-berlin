using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootcampBerlin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Speakers()
        {
            return View();
        }

        public ActionResult Location()
        {
            return View();
        }
    }
}
