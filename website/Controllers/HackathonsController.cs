using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using website.Models;
using System.IO;
using website.Utilities;
using website.Data;

namespace website.Controllers
{
    /// <summary>
    /// Hackathons controller.
	/// Display information about hackathons I have participated in.
    /// </summary>
	public class HackathonsController : Controller
    {
		/// <summary>
		/// The hackathons repository.
		/// </summary>
		private HackathonsRepository _hackathonsRepository = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="website.Controllers.HackathonsController"/> class.
		/// </summary>
		public HackathonsController()
		{
			_hackathonsRepository = new HackathonsRepository();
		}

		public ActionResult Index()
        {
			return View(_hackathonsRepository.GetHackathons());
        }
    }
}
