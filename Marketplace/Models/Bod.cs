using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bod
    {
        public int Id { get;private set; }
        public decimal Bedrag { get;private set; }
        public Bod(int id, decimal bedrag)
        {
            Id = id;
            Bedrag = bedrag;
        }
    }
}
