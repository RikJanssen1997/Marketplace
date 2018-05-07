using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Foto
    {
        public int Id { get; private set; }
        public Foto(int id)
        {
            Id = id;
        }
    }
}
