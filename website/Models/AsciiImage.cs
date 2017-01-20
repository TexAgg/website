using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace website.Models
{
	public class AsciiImage
	{
		[Required]
		public HttpPostedFileBase File { get; set; }
		public int? Width { get; set; }
		public int? Height { get; set; }
	}
}

