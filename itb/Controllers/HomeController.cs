using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace itb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = @"vrn\Администраторы домена")]
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Profil()
        {
            return View();
        }

        public PartialViewResult _ButtonClick( string str )
        {
            ViewBag.str = str;
            return PartialView();
        }
    }
}