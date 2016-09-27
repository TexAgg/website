using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Controllers
{
    /// <summary>
    /// Hackathons controller.
	/// Display information about hackathons I have participated in.
    /// </summary>
	public class HackathonsController : Controller
    {
        public ActionResult Index()
        {			
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+  "hackathons.json";
			// http://stackoverflow.com/a/16921677/5415895
			Hackathons hackathons = JsonHelpers.ReadJsonFromFile<Hackathons>(filePath);

			return View(hackathons);
        }
    }
}
