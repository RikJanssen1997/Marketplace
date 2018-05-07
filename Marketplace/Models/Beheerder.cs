using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Beheerder:Gebruiker
    {
        public int BeheerderId { get; private set; }
        public Beheerder(int id, string gebruikersnaam, string wachtwoord, int beheerderId)
        {
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            BeheerderId = beheerderId;

        }


    }
}
