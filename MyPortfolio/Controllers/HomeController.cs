using MyPortfolio.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
           
        }

        public ActionResult Skills()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }


    }
}