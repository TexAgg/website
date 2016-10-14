using System;
using System.Web.Mvc;

namespace Utilities
{
	/// <summary>
	/// HTML utilities.
	/// </summary>
	public static class HTMLUtilities
	{
		/// <summary>
		/// An extension method to make a navbar link class active.
		/// Code found here: http://stackoverflow.com/a/22408778/5415895
		/// </summary>
		/// <returns>Either active or null.</returns>
		/// <param name="urlHelper">URL helper.</param>
		/// <param name="controller">Controller.</param>
		public static string MakeActiveClass(this UrlHelper urlHelper, string controller)
		{
			string result = "active";

			string controllerName = urlHelper.RequestContext.RouteData.Values["controller"].ToString();

			if (!controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
			{
				result = null;
			}

			return result;
		}
	}
}

