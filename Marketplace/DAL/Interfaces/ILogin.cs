using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILogin
    {
        Klant GetKlant(string gebruikersnaam, string wachtwoord);
        Beheerder GetAdmin(string gebruikersnaam, string wachtwoord);
    }
}
