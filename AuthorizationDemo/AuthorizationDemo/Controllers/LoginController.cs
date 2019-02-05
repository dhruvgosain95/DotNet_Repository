using AuthorizationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthorizationDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user,string ReturnUrl)
        {
            if (isValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.username, false);
                return Redirect(ReturnUrl);
            }
            else
            {
                return View(user);
            }
            return View();
        }
        private bool isValid(User user)
        {
            return (user.username == "pinchu" && user.password == "panda");
        }
    }
}