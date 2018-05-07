using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VerzondenBericht
    {
        public int Id { get; private set; }
        public string Tekst { get; private set; }
        public int VolgordeNummer { get; private set; }
        public VerzondenBericht(int id, string tekst, int volgordeNummer)
        {
            Id = id;
            Tekst = tekst;
            VolgordeNummer = volgordeNummer;
        }
    }
}
