using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizationDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            ViewData["username"] = User.Identity.Name;
            return View();
        }
    }
}