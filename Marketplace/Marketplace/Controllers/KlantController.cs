using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace.Controllers
{
    public class KlantController : Controller
    {
        // GET: Klant
        public ActionResult Index(Klant k)
        {
            return View();
        }
    }
}