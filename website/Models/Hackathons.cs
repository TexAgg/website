using System;
using System.Collections.Generic;

namespace website
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
			public string Name { get; set; }
			/// <summary>
			/// The year the hackathon took place.
			/// </summary>
			public int Year { get; set; }
			/// <summary>
			/// An HTML string talking about the project.
			/// </summary>
			public string AboutHTML { get; set; }
		}
	}
}

