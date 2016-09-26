using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;

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
				Proficient = new List<string> {
					"C++",
					"LaTeX",
					"R"
				},
				Familiar = new List<String> {
					"Javascript",
					"Java",
					"Mathematica",
					"C#",
					"PHP",
					"Python"
				},
				Software = new List<string>{
					"Git",
					"Linux",
					"CMake",
					"ASP.NET MVC",
					"Flask",
					"NodeJS"
				}
			};
					
			return View(skills);
        }
    }
}
