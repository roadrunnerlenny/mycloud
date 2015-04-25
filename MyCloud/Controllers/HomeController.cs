using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Net;
using System.Web.Caching;
using MyCloud;

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

			return View ();
		}

        public ActionResult Browse()
        {
			string pathName = Request["PathName"];

			string decodedPathName = MonoHelper.DecodeName (pathName);

			ViewData["RootDir"] = backup.SparseBundle.FindFolder(decodedPathName);
			return View();
        }

		public ActionResult Download()
		{
			string fileName = Request ["FileName"];
			string decodedFileName = MonoHelper.DecodeName (fileName);

			FileModel downloadFile = backup.SparseBundle.FindFile (decodedFileName);
		
			return File (downloadFile.File.FullName, "application/octet-stream", downloadFile.File.Name);
		}





	}
}

