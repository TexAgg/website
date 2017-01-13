using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
	/// <summary>
	/// Graph controller.
	/// </summary>
	public class GraphController : Controller
	{
		/// <summary>
		/// Display information about the graph.
		/// </summary>
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// The dot file.
		/// </summary>
		public ActionResult Graph()
		{
			string path = Server.MapPath("~/Content/Graph/graph.gv");
			return File(path, "text/plain");
		}

		/// <summary>
		/// The source code for making the graph.
		/// </summary>
		public ActionResult Source()
		{
			string path = Server.MapPath("~/Content/Graph/graph.wl");
			return File(path, "text/plain");
		}
	}
}
