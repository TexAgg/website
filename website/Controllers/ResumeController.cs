using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    /// <summary>
    /// Resume controller.
	/// Display my resume.
    /// </summary>
	public class ResumeController : Controller
    {
        /// <summary>
        /// Default route for the resume controller.
        /// </summary>
		public ActionResult Index()
        {
			return View();
        }
    }
}
