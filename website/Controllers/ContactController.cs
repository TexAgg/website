using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
	/// <summary>
	/// Contact controller.
	/// Display my contact information.
	/// </summary>
	public class ContactController : Controller
	{
	   /// <summary>
	   /// Default route of the contact controller.
	   /// </summary>
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult PromoCodes()
		{
			Dictionary<string, string> codes = new Dictionary<string, string>()
			{
				{"Uber", "https://www.uber.com/invite/mattg19585ue"},
				{"Dropbox", "https://db.tt/UPxLPnE7"}
			};

			return View(codes);
		}
	}
}
