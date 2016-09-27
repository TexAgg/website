using System;
using System.Collections.Generic;

namespace website.Models
{
	/// <summary>
	/// Model class for my skills.
	/// </summary>
	public class Skills
	{
		/// <summary>
		/// Languages I am proficient in.
		/// </summary>
		public List<string> proficient { get; set; }
		/// <summary>
		/// Languages I am familiar with.
		/// </summary>
		public List<string> familiar { get; set; }
		/// <summary>
		/// Software I know.
		/// </summary>
		public List<string> software { get; set; }
	}
}

