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
    public class AsciiConvertController : Controller
    {
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

			if (model.Height != null && model.Width == null)
				ascii = new AsciiArt.AsciiArt(img, model.Height.Value, model.Height.Value);
			else if (model.Width != null && model.Height == null)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Width.Value);
			else if (model.Height != null && model.Width != null)
				ascii = new AsciiArt.AsciiArt(img, model.Width.Value, model.Height.Value);
			else
				ascii = new AsciiArt.AsciiArt(img);

			return File( Encoding.UTF8.GetBytes(ascii.Generate()), "text/plain", "art.txt");
			//return Content(ascii.Generate());
		}
    }
}
