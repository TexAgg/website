/*
 * This class provides an object for when the JSON file
 * containing a list of my projects is deserialized.
 */

using System;
using System.Collections.Generic;

namespace website.Models
{
	public class Projects
	{
		public List<Item> item { get; set; }

		public class Item
		{
			public string about { get; set; }
			public string display { get; set; }
			public string id { get; set; }
			public string name { get; set; }
		}
	}
}

