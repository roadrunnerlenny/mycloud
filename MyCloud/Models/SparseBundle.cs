using System;

namespace MyCloud
{
	public class SparseBundle
	{
		public DirModel Content { get; set; }

		public SparseBundle (string mountPath)
		{
			Content = new DirModel (mountPath);
		}
	}
}

