using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myPro.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.test = "Testing...";
			ViewBag.title = "Test Title";
            return View();
        }
    }
}
