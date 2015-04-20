using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Net;

namespace MyCloud.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			TimeMachine backup = new TimeMachine ();
			ViewData ["TimeMachine"] = backup;
			ViewData ["RootDir"] = backup.SparseBundle.Content;
			ViewData ["SubDirs"] = backup.SparseBundle.Content.SubDirs;

			/*string app_id = Request["app_id"];
			string session_id = Request["session_id"];
			int surah_id = Int32.Parse(Request["surah_id"]);
			int ayat_id = Int32.Parse(Request["ayat_id"]);*/


			return View ();
		}

        public ActionResult Browse()
        {
			string pathName = Request["PathName"];
			string decodedPathName = WebUtility.HtmlDecode (pathName);
			decodedPathName = decodedPathName.Replace ('|', '/');

			ViewData["RootDir"] = new DirModel(decodedPathName);            
			return View();
        }



	}
}

