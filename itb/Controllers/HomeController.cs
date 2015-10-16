using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.DirectoryServices.AccountManagement;
using itb.Models;


namespace itb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = @"vrn\Администраторы домена")]
        [Authorize(Users = @"vrn\tl")]
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Profil()
        {
            return View();
        }

        public PartialViewResult _ButtonClickSave( string str )
        {
            var ctx = new PrincipalContext(ContextType.Domain);
            var user = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, User.Identity.Name);
            str = user.DisplayName;

            ViewBag.str = str;

            return PartialView();
        }

    }
}