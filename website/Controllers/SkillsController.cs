using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using website.Utilities;
using System.IO;
using website.Data;

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
			return View(SkillsRepository.GetSkills());
        }
    }
}
