using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypicalBusiness.Models;

namespace TypicalBusiness.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [Route("Home/Index")]
        [LayoutInjecter("_IndexLayout")]
        public ActionResult Index()
        {
            return View();
        }
       
        [Route("Home/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("Home/Services")]
        public ActionResult Services()
        {
            ViewBag.Message = "Your Services page";

            return View();
        }

        [Route("Home/Career")]
        public ActionResult Career()
        {
            ViewBag.Message = "Your Career page";

            return View(db.Jobs.ToList());
        }


    }
}