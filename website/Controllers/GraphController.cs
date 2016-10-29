using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class GraphController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Graph()
		{
			return File("Content/Graph/graph.gv", "text/plain");
		}

		public ActionResult Source()
		{
			return File("Content/Graph/graph.wl", "text/plain");
		}
    }
}
