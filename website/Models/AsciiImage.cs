using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
	/// <summary>
	/// ASCII image.
	/// </summary>
	public class AsciiImage
	{
		/// <summary>
		/// Gets or sets the file.
		/// </summary>
		/// <value>The file.</value>
		[Required]
		public HttpPostedFileBase File { get; set; }
		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		public int? Width { get; set; }
		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		public int? Height { get; set; }
	}
}

