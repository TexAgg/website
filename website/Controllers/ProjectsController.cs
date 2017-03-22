using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using website.Models;
using website.Utilities;
using website.Data;
using System.Drawing;

namespace website.Controllers
{
	/// <summary>
	/// Projects controller.
	/// Displays all my projects and also handles routes to some small javascript projects.
	/// </summary>
	public class ProjectsController : Controller
    {
		/// <summary>
		/// The projects repository.
		/// </summary>
		private ProjectsRepository _projectsRepository = null;
		private Dictionary<string, Projects.Item> _projectNames;

		/// <summary>
		/// Initializes a new instance of the <see cref="website.Controllers.ProjectsController"/> class.
		/// </summary>
		public ProjectsController()
		{
			_projectsRepository = new ProjectsRepository();
			_projectNames = new Dictionary<string, Projects.Item>();
			foreach (var item in _projectsRepository.GetProjects().item)
			{
				_projectNames[item.name] = item;
			}
		}

		/// <summary>
		/// Default action: display projects.
		/// </summary>
		public ActionResult Index()
        {
			return View(_projectsRepository.GetProjects());
        }

		public ActionResult Project(string name)
		{
			if (!_projectNames.ContainsKey(name))
				return Index();
			return View(_projectNames[name]);
		}

		/// <summary>
		/// Redirect to Bubble.
		/// </summary>
		public ActionResult Bubble()
		{
			return Redirect("/Static/Bubble/index.html");
		}

		/// <summary>
		/// Redirect to Triangle Calculator.
		/// </summary>
		public ActionResult TriangleCalculator()
		{
			return Redirect("/Static/triangle_calculator/triangle_calculator/index.html");
		}

		/// <summary>
		/// Redirect to Flap God 2.
		/// </summary>
		public ActionResult FlapGod2()
		{
			return Redirect("/Static/flap_god2/flap_god2/index.html");
		}

		/// <summary>
		/// Redirect to Stoplight.
		/// </summary>
		public ActionResult Stoplight()
		{
			return Redirect ("/Static/Stoplight/index.html");
		}

		/// <summary>
		/// Redirect to Pepe Ball.
		/// </summary>
		public ActionResult PepeBall()
		{
			return Redirect("/Static/PepeBall/index.html");
		}

		/// <summary>
		/// Redirect to timer.
		/// </summary>
		public ActionResult Timer()
		{
			return Redirect("/Static/timer/index.html");
		}

		/// <summary>
		/// Redirect to Snake.
		/// </summary>
		public ActionResult Snake()
		{
			return Redirect("/Static/Snake/index.html");
		}

		/// <summary>
		/// Redirect to Emojify.
		/// </summary>
		public ActionResult Emojify()
		{
			return Redirect("/Static/Emojify/index.html");
		}

		/// <summary>
		/// Show AsciiArt project.
		/// Form not filled out.
		/// </summary>
		/// <returns>The art.</returns>
		public ActionResult AsciiArt()
		{
			return View(new AsciiImage());
		}

		/// <summary>
		/// Show AsciiArt project.
		/// Form filled out.
		/// </summary>
		/// <returns>The art.</returns>
		/// <param name="model">Model.</param>
		[HttpPost]
		public ActionResult AsciiArt(AsciiImage model)
		{
			if (!ModelState.IsValid)
			{
				// the user didn't upload any file =>
				// render the same view again in order to display the error message
				return Content("oops");
			}

			// http://stackoverflow.com/a/1171718/5415895
			Image img = Image.FromStream(model.File.InputStream, true, true);
			AsciiArt.AsciiArt ascii;

			// Valid height, invalid width.
			if (model.Height != null && model.Height > 0 && (model.Width == null || model.Width <= 0))
				ascii = new AsciiArt.AsciiArt(img, model.Height.Value, model.Height.Value);
			// Valid width, invalid height.
			else if ((model.Width != null || model.Width <= 0) && model.Height == null && model.Height > 0)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Width.Value);
			// Both inputs valid.
			else if (model.Height != null && model.Height > 0 && model.Width != null && model.Width > 0)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Height.Value);
			else
				ascii = new AsciiArt.AsciiArt(img);

			// http://stackoverflow.com/a/1569545/5415895
			//return File(Encoding.UTF8.GetBytes(ascii.Generate()), "text/plain", "art.txt");
			// For some reason this looks janky.
			return Content(ascii.Generate(), "text/plain");
		}

		/// <summary>
		/// Landing page for markov text generator.
		/// </summary>
		public ActionResult Markov()
		{
			return View(new MarkovForm());
		}

		/// <summary>
		/// Markov the specified model.
		/// </summary>
		/// <param name="model">Model.</param>
		[HttpGet]
		public ActionResult Markov(MarkovForm model)
		{
			if (!ModelState.IsValid)
			{
				// Redirect to form.
				return Markov();
			}

			MarkovSharp.Markov mark = new MarkovSharp.Markov(model.Text, 1);

			return Content(mark.Generate(), "text/plain");
		}
    }
}
