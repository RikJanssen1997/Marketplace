using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VerzondenBericht
    {
        public int Id { get;private set; }
        public string Tekst { get;private set; }
        public int Volgordenummer { get;private set; }
        public VerzondenBericht(int id, string tekst, int volgordenummer)
        {
            Id = id;
            Tekst = tekst;
            Volgordenummer = volgordenummer;
        }
    }
}
