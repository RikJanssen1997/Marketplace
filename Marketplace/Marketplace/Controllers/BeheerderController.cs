using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace.Controllers
{
    public class BeheerderController : Controller
    {
        // GET: Beheerder
        public ActionResult Index(Beheerder b)
        {
            return View();
        }
    }
}