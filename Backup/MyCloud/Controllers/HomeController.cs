using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MyCloud.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			/*
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";
			*/

			TimeMachine backup = new TimeMachine ();
			ViewData ["TimeMachine"] = backup;
			ViewData ["RootDir"] = backup.SparseBundle.Content;
			ViewData ["SubDirs"] = backup.SparseBundle.Content.SubDirs;

			return View ();
		}



	}
}

