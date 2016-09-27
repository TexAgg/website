using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using website.Utilities;
using System.IO;

namespace website.Controllers
{
    /// <summary>
    /// Skills controller.
	/// Display my skills.
    /// </summary>
	public class SkillsController : Controller
    {
        public ActionResult Index()
        {
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+ "skills.json";
			Skills skills = JsonHelpers.ReadJsonFromFile<Skills>(filePath);
					
			return View(skills);
        }
    }
}
