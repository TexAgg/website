using System;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

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

		/// <summary>
		/// Reads json from a file, and returns an object of type T.
		/// </summary>
		/// <returns>The json from file.</returns>
		/// <param name="filename">Filename.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static T ReadJsonFromFile<T>(string filename)
		{
			StreamReader r = new StreamReader(filename);
			string json = r.ReadToEnd();
			T obj = JsonConvert.DeserializeObject<T>(json);
			return obj;
		}
	}
}

