using System;
using System.IO;
using System.Linq;

namespace MyCloud
{
	public class FileModel
	{
		public FileInfo File { get; set; }

		public FileModel (string fileName)
		{
			this.File = new FileInfo (fileName);
		}
	}
}

