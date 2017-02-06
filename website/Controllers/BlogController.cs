using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Syndication;
using System.Xml;

namespace website.Controllers
{
    /// <summary>
    /// Blog controller.
    /// </summary>
	public class BlogController : Controller
    {
		// http://stackoverflow.com/a/5103589/5415895
		Atom10FeedFormatter _feed;
		Dictionary<String, SyndicationItem> _posts;

		/// <summary>
		/// Initializes a new instance of the <see cref="website.Controllers.BlogController"/> class.
		/// </summary>
		public BlogController()
		{
			_feed = new Atom10FeedFormatter();
			using (XmlReader reader = XmlReader.Create("http://mattgaikema.blogspot.com/feeds/posts/default"))
			{
				_feed.ReadFrom(reader);
			}

			_posts = new Dictionary<string, SyndicationItem>();
			foreach (SyndicationItem item in _feed.Feed.Items)
			{
				_posts.Add(item.Title.Text, item);
			}
		}

		/// <summary>
		/// Default landing page for Blog controller.
		/// </summary>
		public ActionResult Index()
        {
			return View(_feed.Feed);
        }

		/// <summary>
		/// Blog post.
		/// </summary>
		/// <param name="title">Title.</param>
		public ActionResult Post(string title)
		{
			return View(_posts[title]);
		}
    }
}
