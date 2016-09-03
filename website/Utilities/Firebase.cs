using System;
using RestSharp;
using System.Security.Cryptography.X509Certificates;

namespace Utilities
{
	/// <summary>
	/// Utility class for interacting with Firebase database.
	/// Possibly deprecated.
	/// </summary>
	public class Firebase
	{
		private string url;
		private string auth;

		/// <summary>
		/// Initializes a new instance of the <see cref="Utilities.Firebase"/> class.
		/// </summary>
		/// <param name="url">The database url.</param>
		/// <param name="auth">Database secret.</param>
		public Firebase(string url, string auth)
		{
			this.url = url;
			this.auth = auth;
		}
	}
}

