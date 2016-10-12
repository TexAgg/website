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
		/// <summary>
		/// The skills repository.
		/// </summary>
		private SkillsRepository _skillsRepository = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="website.Controllers.SkillsController"/> class.
		/// </summary>
		public SkillsController()
		{
			_skillsRepository = new SkillsRepository();
		}

		/// <summary>
		/// Default route for the skills controller.
		/// </summary>
		public ActionResult Index()
		{					
			return View(_skillsRepository.GetSkills());
		}
	}
}
