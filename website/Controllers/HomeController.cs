using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace website.Controllers
{
	/// <summary>
	/// Home controller.
	/// Display information about me.
	/// </summary>
	public class HomeController : Controller
	{
		/// <summary>
		/// Default route.
		/// </summary>
		public ActionResult Index()
		{
			ViewBag.Section = "about";

			return View();
		}
	}
}

