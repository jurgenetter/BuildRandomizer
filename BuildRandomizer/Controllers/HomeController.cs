using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildRandomizer.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Models.Build build = Models.Randomizer.RandomizeBuild();
			System.Diagnostics.Debug.WriteLine(build.Ascendancy.Name + " : " + build.Ascendancy.BaseClass);
			foreach(Models.SkillGem s in build.SkillList)
			{
				System.Diagnostics.Debug.WriteLine("[ " + s.Name + " ]");
			}
			System.Diagnostics.Debug.WriteLine(build.WeaponType.Name);
			System.Diagnostics.Debug.WriteLine(build.Defense.Name);
			System.Diagnostics.Debug.WriteLine(build.Keystones[0].Name + " : " + build.Keystones[1].Name);

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}