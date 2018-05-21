using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Klant : Gebruiker
    {
        public int KlantId { get;private set; }
        public string Voornaam { get;private set; }
        public string Achternaam { get;private set; }
        public string Email { get;private set; }
        public string Woonplaats { get;private set; }
        public string Adres { get;private set; }
        public string Postcode { get;private set; }
        public string Land { get;private set; }
        public Klant(int id, string gebruikersnaam, string wachtwoord, int klantId, string voornaam, string achternaam, string email, string woonplaats, string adres, string postcode, string land)
        {
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            KlantId = klantId;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Woonplaats = woonplaats;
            Adres = adres;
            Postcode = postcode;
            Land = land;
        }
        
    }
}
