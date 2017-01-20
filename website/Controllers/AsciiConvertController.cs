using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using AsciiArt;
using System.Drawing;
using System.Text;

namespace website.Controllers
{
    /// <summary>
    /// ASCII converter controller.
    /// </summary>
	public class AsciiConvertController : Controller
    {
        /// <summary>
        /// Default landing page for this controller. 
		/// The input page.
        /// </summary>
		public ActionResult Index()
        {
			return View(new AsciiImage());
        }

		[HttpPost]
		public ActionResult Index(AsciiImage model)
		{
			if (!ModelState.IsValid)
			{
				// the user didn't upload any file =>
				// render the same view again in order to display the error message
				return Content("oops");
			}

			// http://stackoverflow.com/a/1171718/5415895
			Image img = Image.FromStream(model.File.InputStream, true, true);
			AsciiArt.AsciiArt ascii;

			// Valid height, invalid width.
			if (model.Height != null && model.Height > 0 && (model.Width == null || model.Width <= 0))
				ascii = new AsciiArt.AsciiArt(img, model.Height.Value, model.Height.Value);
			// Valid width, invalid height.
			else if ((model.Width != null || model.Width <= 0) && model.Height == null && model.Height > 0)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Width.Value);
			// Both inputs valid.
			else if (model.Height != null && model.Height > 0 && model.Width != null && model.Width > 0)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Height.Value);
			else
				ascii = new AsciiArt.AsciiArt(img);

			// http://stackoverflow.com/a/1569545/5415895
			//return File(Encoding.UTF8.GetBytes(ascii.Generate()), "text/plain", "art.txt");
			// For some reason this looks janky.
			return Content(ascii.Generate(), "text/plain");
		}
    }
}
