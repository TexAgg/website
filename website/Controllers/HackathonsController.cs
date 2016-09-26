using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    /// <summary>
    /// Hackathons controller.
	/// Display information about hackathons I have participated in.
    /// </summary>
	public class HackathonsController : Controller
    {
        public ActionResult Index()
        {
			return View();
        }
    }
}
