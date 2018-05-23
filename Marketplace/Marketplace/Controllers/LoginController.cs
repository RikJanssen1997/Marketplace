using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ViewModels;
using Logic;
using DAL;
  

namespace Marketplace.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            KlantBeheerder kb = new KlantBeheerder();
            return View();
        }
        public ActionResult Login(KlantBeheerder kb)
        {
            Login l = new Login();
            kb = l.kb(new DAL.Context.SQLContext.SQLLogin(), kb.gebruikersnaam, kb.wachtwoord);
            if(kb.klant != null)
            {
                Session["Gebruikersnaam"] = kb.klant.Gebruikersnaam;
                return RedirectToAction("Index", "Klant", new { k = kb.klant });
            }
            if (kb.beheerder != null)
            {
                Session["Gebruikersnaam"] = kb.beheerder.Gebruikersnaam;
                return RedirectToAction("Index", "Beheerder", new { b = kb.beheerder });
            }
            else
            {
                ViewBag.Error = "Foute inloggegevens";
                return View("Index");
            }
        }
       
    }
}