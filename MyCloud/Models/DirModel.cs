using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MyCloud
{
	public class DirModel
	{
		public DirectoryInfo Dir { get; set; }

		public DirModel Parent { get; set; }  
		public bool HasParent {
			get {
				return Parent != null;
			}
		}

		public List<DirModel> SubDirs { get; set; }
		public List<FileModel> Files { get; set; } 

		public string EncodedFullName { 
			get {
				return MonoHelper.EncodeName (Dir.FullName);
			}
		}

		public string EncodedParent {
			get {
				if (HasParent)
					return MonoHelper.EncodeName (Parent.Dir.FullName);
				else
					return "No Parent";
			}
		}

		public DirModel (string path)
		{
			Dir = new DirectoryInfo (path);
			if (Dir.Parent != null && Dir.Parent.Exists)
				Parent = new DirModel (Dir.Parent.FullName);

		}
			
		public void LoadSubDirs() {
			SubDirs = Directory.GetDirectories (Dir.FullName)
				.Select (subDirPath => new DirModel (subDirPath)).ToList ();

		}

		public void LoadFiles() {
			Files = Directory.GetFiles(Dir.FullName)
				.Select(fileName => new FileModel(fileName)).ToList();
		}
			

	}    
}

