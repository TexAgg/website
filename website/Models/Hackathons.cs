using System;
using System.Collections.Generic;

namespace website.Models
{
	/// <summary>
	/// Hackathons data model.
	/// </summary>
	public class Hackathons
	{
		/// <summary>
		/// List of hackathons.
		/// </summary>
		public List<Item> item { get; set; }

		/// <summary>
		/// Individual hackathon.
		/// </summary>
		public class Item
		{
			/// <summary>
			/// Name of the hackathon.
			/// </summary>
			public string name { get; set; }
			/// <summary>
			/// The year the hackathon took place.
			/// </summary>
			public int year { get; set; }
			/// <summary>
			/// An HTML string talking about the project.
			/// </summary>
			public string aboutHTML { get; set; }
			/// <summary>
			/// Tags describing the project.
			/// </summary>
			public List<string> tags { get; set; }
		}
	}
}

