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

		/*public DirModel (string path)
		{
			Dir = new DirectoryInfo (path);
			Files = Directory.GetFiles(path)
				.Select(fileName => new FileModel(fileName)).ToList();
		}*/

		public void LoadSubDirs() {
			SubDirs = Directory.GetDirectories (Dir.FullName)
				.Select (subDirPath => new DirModel (subDirPath)).ToList ();

		}

		public void LoadFiles() {
			Files = Directory.GetFiles(Dir.FullName)
				.Select(fileName => new FileModel(fileName)).ToList();
		}

		/*
		public DirModel (string path)
		{
			Dir = new DirectoryInfo (path);

			SubDirs = Directory.GetDirectories (path)
				.Select (subDirPath => new DirModel (subDirPath,this)).ToList ();

			Files = Directory.GetFiles(path)
				.Select(fileName => new FileModel(fileName)).ToList();
			
		}

		public DirModel (string path, DirModel parent) : this(path)
		{
			this.Parent = parent;
		}

		public DirModel FindPath(string path) {
			if (Dir.FullName == path)
				return this;
			else {
				DirModel result = null;
				foreach (DirModel subDir in SubDirs) {
					result = subDir.FindPath (path);
					if (result != null)
						break;
				}
				return result;
			}
		}

		public FileModel FindFile(string fileName) {
			if (this.Files.Any(f => f.File.FullName == fileName))
				return Files.Where (f => f.File.FullName == fileName).First();
			else {
				FileModel result = null;
				foreach (DirModel subDir in SubDirs) {
					result = subDir.FindFile(fileName);
					if (result != null)
						break;
				}
				return result;
			}
		}
		*/

      


	}    
}

