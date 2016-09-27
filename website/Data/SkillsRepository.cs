using System;
using website.Models;
using System.IO;
using website.Utilities;

namespace website.Data
{
	/// <summary>
	/// Skills repository.
	/// </summary>
	public class SkillsRepository
	{
		/// <summary>
		/// Gets the skills.
		/// </summary>
		/// <returns>The skills model object.</returns>
		public Skills GetSkills()
		{
			String filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath 
				+ Path.DirectorySeparatorChar 
				+ "App_Data" 
				+ Path.DirectorySeparatorChar 
				+ "skills.json";
			Skills skills = JsonHelpers.ReadJsonFromFile<Skills>(filePath);
			return skills;
		}
	}
}

