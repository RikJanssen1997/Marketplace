using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using DAL.Context;

namespace Marketplace.Controllers
{
    public class KlantController : Controller
    {
        // GET: Klant
        public ActionResult Index(Klant k)
        {
            List<Advertentie> advertentieslist = new List<Advertentie>();
            Advertenties a = new Advertenties();
            advertentieslist = a.GetAllAdvertenties(new DAL.Context.SQLContext.SQLAdvertenties());
            return View(advertentieslist);
        }
        public ActionResult AdvertentieDetails(int advertentie)
        {

            
            Advertenties a = new Advertenties();
            Advertentie ad = a.GetAdvertentie(new DAL.Context.SQLContext.SQLAdvertenties(), advertentie);
            return View(ad);
        }
    }
}