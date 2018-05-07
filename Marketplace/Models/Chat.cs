using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Chat
    {
        public int Id { get; private set; }
        public List<VerzondenBericht> VerzondenBerichten { get; set; }
        public List<Gebruiker> Gebruikers { get; set; }
        public Chat(int id)
        {
            Id = id;
        }
    }
}
