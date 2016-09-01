using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Title = "Projects";

			// TODO: Read the JSON file with the projects.

			return View ();
        }
    }
}
