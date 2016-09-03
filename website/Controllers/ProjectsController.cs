using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using website.Models;

namespace website.Controllers
{
    /// <summary>
    /// Projects controller.
    /// </summary>
	public class ProjectsController : Controller
    {
		/// <summary>
		/// Default action: display projects.
		/// </summary>
		public ActionResult Index()
        {
			ViewBag.Title = "Projects";

			// TODO: Read the JSON file with the projects.
			// http://stackoverflow.com/a/13297964/5415895
			StreamReader r = new StreamReader("App_Data/projects.json");
			string json = r.ReadToEnd();
			Projects projects = JsonConvert.DeserializeObject<Projects>(json);
			ViewBag.Projects = projects;

			return View();
        }

		/// <summary>
		/// Redirect to Bubble.
		/// </summary>
		public ActionResult Bubble()
		{
			return Redirect("~/Static/Bubble/index.html");
		}

		/// <summary>
		/// Redirect to Triangle Calculator.
		/// </summary>
		public ActionResult TriangleCalculator()
		{
			return Redirect("~/Static/triangle_calculator/index.html");
		}

		/// <summary>
		/// Redirect to Flap God 2.
		/// </summary>
		public ActionResult FlapGod2()
		{
			return Redirect("~/Static/flap_god2/index.html");
		}
    }
}
