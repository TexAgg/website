using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace website.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewBag.Title = "Matt Gaikema";

			return View ();
		}
	}
}

