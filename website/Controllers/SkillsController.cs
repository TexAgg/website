using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class SkillsController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Title = "Skills";

			// A list of skills I am proficient in.
			List<String> proficient_skills = new List<String> {
				"C/C++",
				"R",
				"LaTeX"
			};
			ViewBag.ProficientSkills = proficient_skills;

			// A list of skills I am familiar with.
			List<String> familiar_skills = new List<String> {
				"Javascript",
				"Java",
				"Mathematica",
				"C#",
				"PHP",
				"Python"
			};
			ViewBag.FamiliarSkills = familiar_skills;
				
			return View ();
        }
    }
}
