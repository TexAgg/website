using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using website.Utilities;
using System.Web.UI.WebControls;
using System.IO;

namespace website.Controllers
{
    /// <summary>
    /// Research controller.
	/// Display information about research I have done.
    /// </summary>
	public class ResearchController : Controller
    {
        public ActionResult Index()
        {
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+  "research.json";
			Research research = JsonHelpers.ReadJsonFromFile<Research>(filePath);

			return View(research);
        }
    }
}
