using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;

namespace website.Controllers
{
    /// <summary>
    /// Research controller.
	/// Display information about research I have done.
    /// </summary>
	public class ResearchController : Controller
    {
        public ActionResult Index()
        {
			Research research = new Research {
				
			};

			return View(research);
        }
    }
}
