using System;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Data
{
	/// <summary>
	/// Research repository.
	/// </summary>
	public static class ResearchRepository
	{
		/// <summary>
		/// Gets the research.
		/// </summary>
		/// <returns>The research model object.</returns>
		public static Research GetResearch()
		{
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+  "research.json";
			Research research = JsonHelpers.ReadJsonFromFile<Research>(filePath);
			return research;
		}
	}
}

