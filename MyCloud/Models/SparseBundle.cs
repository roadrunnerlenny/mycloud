using System;
using System.Linq;
using System.Collections.Generic;

namespace MyCloud
{
	public class SparseBundle
	{
		public DirModel Content { get; set; }

		public SparseBundle (string mountPath)
		{
			Content = new DirModel (mountPath);
		}

		/*
		public DirModel FindFolder(string path) {
			return Content.FindPath (path);
		}

		public FileModel FindFile (string fileName)
		{
			return Content.FindFile (fileName);
		}
		*/
	}
}

