using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myPro.Controllers
{
    public class ABController : Controller
    {
        public ActionResult PV()
		{
			ViewBag.part = "Part";
			return PartialView();
		}
    }
}
