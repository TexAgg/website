using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using website.Utilities;
using System.Web.UI.WebControls;
using System.IO;
using website.Data;

namespace website.Controllers
{
    /// <summary>
    /// Research controller.
	/// Display information about research I have done.
    /// </summary>
	public class ResearchController : Controller
    {
		/// <summary>
		/// The research repository.
		/// </summary>
		private ResearchRepository _researchRepository = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="website.Controllers.ResearchController"/> class.
		/// </summary>
		public ResearchController()
		{
			_researchRepository = new ResearchRepository();
		}

		public ActionResult Index()
        {
			return View(_researchRepository.GetResearch());
        }
    }
}
