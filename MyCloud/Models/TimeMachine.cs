﻿using System;

namespace MyCloud
{
	public class TimeMachine
	{
		public const string _defaultDir = "/Users/Andreas/MonoDevelop/";

		public SparseBundle SparseBundle { get; set; }

		public TimeMachine ()
		{
			SparseBundle = new SparseBundle (_defaultDir);
		}
	}
}
