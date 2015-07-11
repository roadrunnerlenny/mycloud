using System;
using System.IO;
using System.Linq;

namespace MyCloud
{
	public class FileModel
	{
		public FileInfo File { get; set; }

		public string SizeInMB { 
			get {
				return (Math.Round( (decimal)File.Length / (decimal)(1024*1024),2)).ToString() + " MB";
			}
		}

		public string EncodedFullName { 
			get {
				return MonoHelper.EncodeName (File.FullName);
			}
		}

		public FileModel (string fileName)
		{
			this.File = new FileInfo (fileName);
		}
	}
}

