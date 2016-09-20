using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    /// <summary>
    /// Contact controller.
	/// Display my contact information.
    /// </summary>
	public class ContactController : Controller
    {
       /// <summary>
       /// Main route of the contact controller.
       /// </summary>
		public ActionResult Index()
        {
			ViewBag.Title = "Contact";
			ViewBag.Title = "contact";

			return View();
        }
    }
}
