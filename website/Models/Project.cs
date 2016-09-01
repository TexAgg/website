using System;
using System.Collections.Generic;

namespace website.Models
{
	public class Item
	{
		public string about { get; set; }
		public string display { get; set; }
		public string id { get; set; }
		public string name { get; set; }
	}

	public class RootObject
	{
		public List<Item> item { get; set; }
	}
}

