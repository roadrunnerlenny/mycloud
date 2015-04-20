using System;

namespace MyCloud
{
	public class TimeMachine
	{
        public const string _defaultDir = @"D:\ALE\mycloud\MyCloud";//"/Users/Andreas/MonoDevelop/";


		public SparseBundle SparseBundle { get; set; }

		public TimeMachine ()
		{
			SparseBundle = new SparseBundle (_defaultDir);
		}
	}
}

