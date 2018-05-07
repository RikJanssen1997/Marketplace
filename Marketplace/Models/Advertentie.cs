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
        public decimal Beginprijs { get; private set; }
        public decimal NuKopenPrijs { get; private set; }
        public string Titel { get; private set; }
        public DateTime Einddatum { get; private set; }
        public string Omschrijving { get; private set; }
        public List<Foto> Fotos { get; set;}
        public List<Bod> Boden { get; set; }
        public Advertentie(int id, decimal beginprijs, decimal nuKopenPrijs, string titel, DateTime einddatum, string omschrijving)
        {
            Id = id;
            Beginprijs = beginprijs;
            NuKopenPrijs = nuKopenPrijs;
            Titel = titel;
            Einddatum = einddatum;
            Omschrijving = omschrijving;
            
        }
    }
}
