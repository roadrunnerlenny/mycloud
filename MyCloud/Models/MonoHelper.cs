using System;
using System.Net;

namespace MyCloud
{
	//No, this encoding is not a joke. This is serious. Mono still has quite some flaws in ASP.NET
	//and this looks like a valid workaround
	public class MonoHelper
	{
		public static string EncodeName(string s) 
		{
			s = WebUtility.HtmlEncode (s);
			s = EncodeSpecial (s);
			return s;
		}

		public static string DecodeName(string s) 
		{
			s = DecodeSpecial (s);
			s = WebUtility.HtmlDecode (s);
			return s;
		}

		public static string EncodeSpecial(string s) {
			s = s.Replace ('/', '|');
			s = s.Replace ("&#", ":");
			return s;
		}

		public static string DecodeSpecial(string s) {
			s = s.Replace ('|', '/');
			s = s.Replace (":", "&#");
			return s;
		}

		public MonoHelper ()
		{
		}
	}
}

