using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Advertentie
    {
        public int Id { get; private set; }
        public int KlantId { get; private set; }
        public decimal Beginprijs { get; private set; }
        public decimal Nu_Kopen_Prijs { get; private set; }
        public string Titel { get; private set; }
        public DateTime Einddatum { get; private set; }
        public string Omschrijving { get; private set; }
        public Advertentie(int id,int klantId, decimal beginprijs, decimal nu_kopen_prijs, string titel, DateTime einddatum, string omschrijving)
        {
            Id = id;
            klantId = KlantId;
            Beginprijs = beginprijs;
            Nu_Kopen_Prijs = nu_kopen_prijs;
            Titel = titel;
            Einddatum = einddatum;
            Omschrijving = omschrijving;
        }
    }
}
