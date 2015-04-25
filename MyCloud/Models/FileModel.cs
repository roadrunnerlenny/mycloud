using System;
using System.IO;
using System.Linq;

namespace MyCloud
{
	public class FileModel
	{
		public FileInfo File { get; set; }

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

