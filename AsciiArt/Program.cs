using System;
using System.Drawing;
using System.IO;

namespace AsciiArt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string filename = args[0];
			AsciiArt ascii = new AsciiArt(Image.FromFile(filename));
			string result = ascii.Generate();
			System.Console.Write(result);
			// For debugging.
			StreamWriter fwriter = new StreamWriter(Path.GetFileNameWithoutExtension(filename) + ".txt");
			fwriter.WriteLine(result);
		}
	}
}
