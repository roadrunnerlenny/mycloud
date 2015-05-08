using System;
using System.Linq;
using System.Collections.Generic;

namespace MyCloud
{
	public class SparseBundle
	{
		public const string _defaultDir =  "/Users/Andreas/";//"/mnt/backup/";

		public DirModel Content { get; set; }

		public SparseBundle ()
		{
			Content = new DirModel (_defaultDir);
		}

	}
}

