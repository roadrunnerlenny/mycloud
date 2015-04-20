﻿using System;
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
			TimeMachine backup = new TimeMachine ();
			ViewData ["TimeMachine"] = backup;
			ViewData ["RootDir"] = backup.SparseBundle.Content;
			ViewData ["SubDirs"] = backup.SparseBundle.Content.SubDirs;

			return View ();
		}

        public ActionResult Browse(PathInfo pathInfo)
        {
            ViewData["RootDir"] = new DirModel(pathInfo.PathName);            return View();
        }



	}
}

