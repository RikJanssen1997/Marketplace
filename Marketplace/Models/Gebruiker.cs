using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Gebruiker
    {
        public int Id { get; set; }
        [Display (Name ="Gebruikersnaam")]
        public string Gebruikersnaam { get; set; }
        [Display(Name = "Wachtwoord")]
        public string Wachtwoord { get; set; }
    }
}
