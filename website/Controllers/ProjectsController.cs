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
    }
}
