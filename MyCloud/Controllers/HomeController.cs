using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Net;
using System.Web.Caching;

namespace MyCloud.Controllers
{
	public class HomeController : Controller
	{
		public static TimeMachine backup;

		public ActionResult Index ()
		{
			
			backup = new TimeMachine ();
			ViewData ["TimeMachine"] = backup;
			ViewData ["RootDir"] = backup.SparseBundle.Content;
		
			/*string app_id = Request["app_id"];
			string session_id = Request["session_id"];
			int surah_id = Int32.Parse(Request["surah_id"]);
			int ayat_id = Int32.Parse(Request["ayat_id"]);*/


			return View ();
		}

        public ActionResult Browse()
        {
			string pathName = Request["PathName"];

			string decodedPathName = DirModel.DecodeName (pathName);

			//ViewData["RootDir"] = new DirModel(decodedPathName); 
			ViewData["RootDir"] = backup.SparseBundle.FindFolder(decodedPathName);
			return View();
        }

		public ActionResult FolderDown()
		{
			/*string folderName = Request ["Name"];
			string decodedPathName = DirModel.DecodeName (folderName);
			var currentDir = ViewData ["RootDir"] as DirModel;
			ViewData ["RootDir"] = currentDir.SubDirs.Where (d => d.Dir.Name == decodedPathName).First ();
			curDir = currentDir.SubDirs.Where (d => d.Dir.Name == decodedPathName).First () as DirModel;
*/
			return View();
		}

		public ActionResult FolderUp()
		{
		 //ViewData["RootDir"]
			return View();
		}



	}
}

