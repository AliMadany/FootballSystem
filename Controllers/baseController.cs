using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M3gogo.Controllers
{
    public class baseController : Controller
    {
        // GET: base
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult insideclub()
        {
            return View();
        }

        public ActionResult adminview()
        {
            return View();
        }


    }
}