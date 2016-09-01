using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class ResumeController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Title = "Resume";

			return View ();
        }
    }
}
