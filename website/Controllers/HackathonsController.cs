using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Controllers
{
    /// <summary>
    /// Hackathons controller.
	/// Display information about hackathons I have participated in.
    /// </summary>
	public class HackathonsController : Controller
    {
        public ActionResult Index()
        {
			Hackathons hackathons = new Hackathons {
				item = new List<Hackathons.Item> {
					new Hackathons.Item {
						name = "HackDFW",
						year = 2016,
						aboutHTML = "<a href='http://devpost.com/software/ilumi-therapy'>Ilumi-Therapy</a> is an android app that me and my team created for HackDFW. " +
							"It is based on the concept of Light Therapy, an emerging field in medical science. It was created using the <a href='http://ilumi.co/'>Ilumi</a> Smart Bulb SDK, " +
							"and it won us first place in Ilumi's contest for the most creative use of their SDK at the hackathon. " +
							"The source code can be found <a href='https://github.com/ralphie9224/IlumiApp'>here.</a>"
					}
				}	
			};
					
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
			// http://stackoverflow.com/a/16921677/5415895
			JsonHelpers.WriteJsonToFile(filePath + Path.DirectorySeparatorChar + "App_Data" + Path.DirectorySeparatorChar +  "hackathons.json", hackathons);

			return View(hackathons);
        }
    }
}
