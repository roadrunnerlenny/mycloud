using System;
using System.Linq;

namespace MyCloud
{
	public class TimeMachine
	{
		public const string _defaultDir = "/Users/Andreas/MonoDevelop/";//@"D:\ALE\mycloud\MyCloud";


		public SparseBundle SparseBundle { get; set; }

		public TimeMachine ()
		{
			SparseBundle = new SparseBundle (_defaultDir);
		}
	}
}

