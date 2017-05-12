using identitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace identitySample.Controllers
{
    public class HomeController : Controller
    {
        UserManagerApp usermanagerApp
        {
            get
            {
                IOwinContext owin = HttpContext.GetOwinContext();
                return owin.GetUserManager<UserManagerApp>();

            }
        }
        public HomeController()
        {



        }

        // GET: Home
        public ActionResult Index()
        {
            return View(usermanagerApp.Users);
        }
    }
}