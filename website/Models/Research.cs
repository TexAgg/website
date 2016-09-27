using System;
using System.Collections.Generic;

namespace website.Models
{
	/// <summary>
	/// Research data model.
	/// </summary>
	public class Research
	{
		/// <summary>
		/// List of research projects.
		/// </summary>
		public List<Item> item { get; set; }

		/// <summary>
		/// Individual research project.
		/// </summary>
		public class Item
		{
			/// <summary>
			/// Title of the research project.
			/// </summary>
			public string title { get; set; }
			/// <summary>
			/// The timespan of the research.
			/// </summary>
			public string date { get; set; }
			/// <summary>
			/// Description of the project.
			/// </summary>
			public string aboutHTML { get; set; }
			/// <summary>
			/// List of professors worked under for the project.
			/// </summary>
			public List<string> advisors { get; set; }
			/// <summary>
			/// List of the people I worked alongside (but not under).
			/// </summary>
			public List<string> partners { get; set; }
		}
	}
}

