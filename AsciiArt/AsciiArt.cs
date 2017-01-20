using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AsciiArt
{
	public class AsciiArt
	{
		private StringBuilder _ascii;
		private Bitmap _bmp;

		// Map shades of gray to characters.
		private static Dictionary<string, char> _charMap = new Dictionary<string, char>()
		{
			{"black", '@'},
			{"charcoal", '#'},
			{"dark gray", '8'},
			{"medium gray", '&'},
			{"medium", 'o'},
			{"gray", ':'},
			{"slate gray", '*'},
			{"light gray", '.'},
			{"white", ' '}
		};

		/// <summary>
		/// Initializes a new instance of the <see cref="AsciiArt.AsciiArt"/> class.
		/// </summary>
		/// <param name="img">Image.</param>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		public AsciiArt(Image img, int width, int height)
		{
			_ascii = new StringBuilder();
			_bmp = new Bitmap(img, width, height);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AsciiArt.AsciiArt"/> class.
		/// </summary>
		/// <param name="img">Image.</param>
		public AsciiArt(Image img)
		{
			_ascii = new StringBuilder();
			_bmp = new Bitmap(img);
		}

		/// <summary>
		/// Generate the ascii art from the image supplied.
		/// </summary>
		public string Generate()
		{
			// Reset the string builder.
			_ascii.Clear();

			for (int y = 0; y < _bmp.Height; y++)
			{
				for (int x = 0; x < _bmp.Width; x++)
				{
					// Get the color of the current pixel.
					Color col = _bmp.GetPixel(x, y);

					// Convert to grayscale by averaging the RGB values.
					int rgb = (col.R + col.B + col.G) / 3;
					col = Color.FromArgb(rgb, rgb, rgb);

					int rValue = int.Parse(col.R.ToString());
					_ascii.Append(GetGrayShade(rValue));

					if (x == _bmp.Width - 1)
						_ascii.AppendLine();
				}
			}

			return _ascii.ToString();
		}

		/// <summary>
		/// Determines which character should be used given a shade of gray.
		/// </summary>
		/// <returns>The gray shade.</returns>
		/// <param name="redValue">Red value.</param>
		private static char GetGrayShade(int redValue)
		{
			char asciiValue;

			if (redValue >= 230)
				asciiValue = _charMap["white"];
			else if (redValue >= 200)
				asciiValue = _charMap["light gray"];
			else if (redValue >= 180)
				asciiValue = _charMap["slate gray"];
			else if (redValue >= 160)
				asciiValue = _charMap["gray"];
			else if (redValue >= 130)
				asciiValue = _charMap["medium"];
			else if (redValue >= 100)
				asciiValue = _charMap["medium gray"];
			else if (redValue >= 70)
				asciiValue = _charMap["dark gray"];
			else if (redValue >= 50)
				asciiValue = _charMap["charcoal"];
			else
				asciiValue = _charMap["black"];

			return asciiValue;
		}
	}
}

