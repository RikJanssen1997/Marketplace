using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Gebruiker
    {
        public int Id { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
    }
}
