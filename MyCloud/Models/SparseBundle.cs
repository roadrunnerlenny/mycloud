using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace MyCloud
{
	public class SparseBundle
	{
		public const string _defaultDir =  "/mnt/backup/";
	
		public DirModel Content { get; set; }

		public SparseBundle ()
		{
			string dir;
			try {
				dir = File.ReadAllText ("Content/DefaultDir.txt");
			}
			catch {
				dir = _defaultDir;
			}
				
			Content = new DirModel (dir);
		}

	}
}

