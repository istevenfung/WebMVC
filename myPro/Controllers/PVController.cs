using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myPro.Controllers
{
    public class PVController : Controller
    {
        public class MyModel
	{
		public int Prop1 { get; set; }
		public int Prop2 { get; set; }
	}

        public PartialViewResult PV()
	{
		TempData["Hello"] = "Hello from PartController";
		//return PartialView();
		var data = new MyModel() { Prop1 = 5, Prop2 = 10 };
		return PartialView("~/Views/Shared/PV.cshtml", data);
	}
    }
}
