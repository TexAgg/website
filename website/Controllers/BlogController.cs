using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Syndication;
using System.Xml;

namespace website.Controllers
{
    public class BlogController : Controller
    {
		// http://stackoverflow.com/a/5103589/5415895
		Atom10FeedFormatter _feed;

		public BlogController()
		{
			_feed = new Atom10FeedFormatter();
			using (XmlReader reader = XmlReader.Create("http://mattgaikema.blogspot.com/feeds/posts/default"))
			{
				_feed.ReadFrom(reader);
			}
		}

		public ActionResult Index()
        {
            return View();
        }
    }
}
