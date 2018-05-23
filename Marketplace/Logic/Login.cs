using DAL.Interfaces;
using Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Login
    {
        
        public KlantBeheerder kb(ILogin i, string naam, string wachtwoord)
        {
            KlantBeheerder kb = new KlantBeheerder();
            kb.beheerder = i.GetAdmin(naam,wachtwoord);
            kb.klant = i.GetKlant(naam, wachtwoord);
            return kb;
        }
    }
}
