using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MyCloud
{
	public class DirModel
	{
		public DirectoryInfo Dir { get; set; }

		public List<DirModel> SubDirs { get; set; }
		public List<FileModel> Files { get; set; } 

		public DirModel (string path)
		{
			Dir = new DirectoryInfo (path);

			SubDirs = Directory.GetDirectories (path)
				.Select (subDirPath => new DirModel (subDirPath)).ToList ();

			Files = Directory.GetFiles(path)
				.Select(fileName => new FileModel(fileName)).ToList();
			
		}


	}
}

