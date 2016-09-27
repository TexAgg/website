using System;
using Newtonsoft.Json;
using System.IO;

namespace website.Utilities
{
	/// <summary>
	/// Json helpers.
	/// </summary>
	public static class JsonHelpers
	{
		/// <summary>
		/// Convert an object to a JSON string and write it to a file name.
		/// </summary>
		/// <param name="filename">Filename.</param>
		/// <param name="json">Serialized Json object.</param>
		public static void WriteJsonToFile(string filename, object json)
		{
			// Convert the model to a pretty json string and write it to a file.
			// http://stackoverflow.com/a/29592314/5415895
			string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
			// http://stackoverflow.com/a/16921677/5415895
			File.WriteAllText(filename, jsonString);
		}

		/* 
		 * When I learn more about generics I will create a function that 
		 * reads a JSON file and converts it to an instance of the object.
		 */
	}
}

