using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Net;

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

		//No, this encoding is not a joke. This is serious. Mono still has a huge flaw in ASP.NET
		//and this looks like a valid workaround
		public string EncodedFullName { 
			get {
				return DirModel.EncodeName (Dir.FullName);
			}
		}

		public string EncodedParent {
			get {
				if (HasParent)
					return DirModel.EncodeName (Parent.Dir.FullName);
				else
					return "no";
			}
		}

		/*public string EncodedName {
			get {
				return DirModel.EncodeName (Dir.Name);
			}
		}*/

		public static string EncodeName(string name) 
		{
			string encodedPath = WebUtility.HtmlEncode (name);
			encodedPath = encodedPath.Replace ('/', '|');
			return encodedPath;
		}

		public static string DecodeName(string encodedName) 
		{
			string decodedPathName = WebUtility.HtmlDecode (encodedName);
			decodedPathName = decodedPathName.Replace ('|', '/');
			return decodedPathName;
		}

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

		public DirModel Find(string path) {
			if (Dir.FullName == path)
				return this;
			else {
				DirModel curDir = null;
				foreach (DirModel subDir in SubDirs) {
					curDir = subDir.Find (path);
					if (curDir != null)
						break;
				}
				return curDir;
			}
		}

      


	}    
}

