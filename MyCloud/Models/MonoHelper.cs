using System;
using System.Net;

namespace MyCloud
{
	public class MonoHelper
	{
		public static string EncodeName(string name) 
		{
			string encodedPath = WebUtility.HtmlEncode (name);
			encodedPath = encodedPath.Replace ('/', '|');
			return encodedPath;
		}

		public static string DecodeName(string encodedName) 
		{
			string decodedPathName = WebUtility.HtmlDecode (encodedName);
			decodedPathName = decodedPathName.Replace ('|', '/');
			return decodedPathName;
		}

		public MonoHelper ()
		{
		}
	}
}

