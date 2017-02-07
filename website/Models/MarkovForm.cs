using System;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
	/// <summary>
	/// Markov form.
	/// </summary>
	public class MarkovForm
	{
		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		[Required]
		public string Text { get; set; }
	}
}

