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
		public List<string> Proficient { get; set; }
		/// <summary>
		/// Languages I am familiar with.
		/// </summary>
		public List<string> Familiar { get; set; }
		/// <summary>
		/// Software I know.
		/// </summary>
		public List<string> Software { get; set; }
	}
}

