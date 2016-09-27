using System;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Data
{
	/// <summary>
	/// Projects repository.
	/// </summary>
	public static class ProjectsRepository
	{
		/// <summary>
		/// Gets the projects.
		/// </summary>
		/// <returns>The projects model object.</returns>
		public static Projects GetProjects()
		{
			// http://stackoverflow.com/a/13297964/5415895
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+  "projects.json";
			Projects projects = JsonHelpers.ReadJsonFromFile<Projects>(filePath);
			return projects;
		}
	}
}

