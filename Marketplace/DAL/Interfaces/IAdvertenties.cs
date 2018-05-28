using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Interfaces
{
    public interface IAdvertenties
    {
        List<Advertentie> GetAllAdvertenties();
        Advertentie GetAdvertentie(int id);
    }
}
