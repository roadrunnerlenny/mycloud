using System;
using System.Net;

namespace MyCloud
{
	//No, this encoding is not a joke. This is serious. Mono still has a huge flaw in ASP.NET
	//and this looks like a valid workaround
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

