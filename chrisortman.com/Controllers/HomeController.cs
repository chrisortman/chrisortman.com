using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chrisortman.com.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
        	ViewBag.Title = "Welcome to my homepage!";
            return View();
        }

    }
}
