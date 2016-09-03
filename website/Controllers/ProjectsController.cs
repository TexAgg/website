using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;

namespace website.Controllers
{
    public class ProjectsController : Controller
    {
        // Default action: display projects.
		public ActionResult Index()
        {
			ViewBag.Title = "Projects";

			// TODO: Read the JSON file with the projects.
			// http://stackoverflow.com/a/13297964/5415895
			StreamReader r = new StreamReader("App_Data/projects.json");
			string json = r.ReadToEnd();
			dynamic data = JsonConvert.DeserializeObject(json);

			return View ();
        }

		public ActionResult Bubble()
		{
			// Redirect to Bubble project.
			return Redirect("~/Static/Bubble/index.html");
		}

		public ActionResult TriangleCalculator()
		{
			// Redirect to Triangle Calculator.
			return Redirect("~/Static/triangle_calculator/index.html");
		}

		public ActionResult FlapGod2()
		{
			// Redirect to Flap God 2.
			return Redirect("~/Static/flap_god2/index.html");
		}
    }
}
