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
			// Hard-code my skills into a Skills object.
			Skills skills = new Skills {
				proficient = new List<string> {
					"C++",
					"LaTeX",
					"R"
				},
				familiar = new List<String> {
					"Javascript",
					"Java",
					"Mathematica",
					"C#",
					"PHP",
					"Python"
				},
				software = new List<string>{
					"Git",
					"Linux",
					"CMake",
					"ASP.NET MVC",
					"Flask",
					"NodeJS"
				}
			};

			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
			JsonHelpers.WriteJsonToFile(filePath + Path.DirectorySeparatorChar + "App_Data" + Path.DirectorySeparatorChar + "skills.json", skills);
					
			return View(skills);
        }
    }
}
