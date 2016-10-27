/*
 * This class provides an object for when the JSON file
 * containing a list of my projects is deserialized.
 */

using System;
using System.Collections.Generic;

namespace website.Models
{
	/// <summary>
	/// Json deserialization for Projects object.
	/// </summary>
	public class Projects
	{
		/// <summary>
		/// List of projects.
		/// </summary>
		public List<Item> item { get; set; }

		/// <summary>
		/// Individual project.
		/// </summary>
		public class Item
		{
			/// <summary>
			/// Short description of project.
			/// </summary>
			public string about { get; set; }
			/// <summary>
			/// HTML display for project.
			/// May be null.
			/// </summary>
			public string display { get; set; }
			/// <summary>
			/// HTML element id.
			/// </summary>
			public string id { get; set; }
			/// <summary>
			/// The name of the project.
			/// </summary>
			public string name { get; set; }
			/// <summary>
			/// The tags describing each project.
			/// </summary>
			public List<string> tags { get; set; }
			public string link { get; set; }
			public string img { get; set; }
		}
	}
}

