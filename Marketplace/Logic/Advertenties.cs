using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Advertenties
    {
        public List<Advertentie> GetAllAdvertenties(IAdvertenties i)
        {
            List<Advertentie> advertentieslist = i.GetAllAdvertenties();
            return advertentieslist;   
        }
        public Advertentie GetAdvertentie(IAdvertenties i, int id)
        {
            Advertentie a = i.GetAdvertentie(id);
            return a;
        }
    }
}
