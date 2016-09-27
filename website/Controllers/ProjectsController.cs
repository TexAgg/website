﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using website.Models;
using website.Utilities;
using website.Data;

namespace website.Controllers
{
    /// <summary>
    /// Projects controller.
	/// Displays all my projects and also handles routes to some small javascript projects.
    /// </summary>
	public class ProjectsController : Controller
    {
		/// <summary>
		/// Default action: display projects.
		/// </summary>
		public ActionResult Index()
        {
			return View(ProjectsRepository.GetProjects());
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
			return Redirect("~/Static/triangle_calculator/triangle_calculator/index.html");
		}

		/// <summary>
		/// Redirect to Flap God 2.
		/// </summary>
		public ActionResult FlapGod2()
		{
			return Redirect("~/Static/flap_god2/flap_god2/index.html");
		}

		/// <summary>
		/// Redirect to Stoplight.
		/// </summary>
		public ActionResult Stoplight()
		{
			return Redirect ("~/Static/Stoplight/index.html");
		}
    }
}
