using System;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Data
{
	/// <summary>
	/// Hackathons repository.
	/// </summary>
	public class HackathonsRepository
	{
		/// <summary>
		/// Gets the hackathons.
		/// </summary>
		/// <returns>The hackathons model object.</returns>
		public Hackathons GetHackathons()
		{
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+  "hackathons.json";
			// http://stackoverflow.com/a/16921677/5415895
			Hackathons hackathons = JsonHelpers.ReadJsonFromFile<Hackathons>(filePath);
			return hackathons;
		}
}
}

