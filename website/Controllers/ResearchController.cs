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

		/// <summary>
		/// Default route for the research controller.
		/// </summary>
		public ActionResult Index()
		{
			Research research = _researchRepository.GetResearch();
			// Sort so that the most recent is first.
			research.item.Sort(delegate(Research.Item lhs, Research.Item rhs) 
			{
					// http://stackoverflow.com/a/230620/5415895
					return rhs.id.CompareTo(lhs.id);
			});
			return View(research);
		}
	}
}
