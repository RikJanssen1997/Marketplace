using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class KlantBeheerder
    {
        public Klant klant { get; set; }
        public Beheerder beheerder { get; set; }
        [Display(Name = "Gebruikersnaam")]
        public string gebruikersnaam { get; set; }
        [Display(Name = "Wachtwoord")]
        public string wachtwoord { get; set; }
    }
}
